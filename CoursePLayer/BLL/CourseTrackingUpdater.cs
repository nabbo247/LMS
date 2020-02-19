using System;
using System.Linq;


namespace HRS.CoursePlayer
{
    public interface ICourseTrackingUpdater
    {
        ContentModuleTracking UpdateTracking(LessonTracking tracking, ContentModuleTracking contModTracking);
    }

    public class CourseTrackingUpdater : ICourseTrackingUpdater
    {
        
        public ContentModuleTracking UpdateTracking(LessonTracking tracking, ContentModuleTracking contModTracking)
        {
            var forCredit = tracking.ForCredit;
            var browseMode = tracking.BrowseMode;
            var trackingExists = contModTracking.LessonTracking.ContainsKey(tracking.Identifier);
            var masteryScore = tracking.MasteryScore;
            var currentScore = tracking.RawScore;
            var currentStatus = tracking.LessonStatus;
            var totalTime = new TimeSpan(0);

            if (trackingExists)
            {
                var existingTracking = contModTracking.LessonTracking[tracking.Identifier];
                masteryScore = existingTracking.MasteryScore;
                currentStatus = existingTracking.LessonStatus;
                currentScore = existingTracking.RawScore;
                totalTime = existingTracking.TotalTime;
            }
            else if (browseMode || !forCredit)
            {
                currentStatus = "browsed";
                currentScore = null;
            }

            //Note: site had only been calculating status based on mastery score for AICC courses, 
            //but we should make it do that for all courses eventually.
            if (contModTracking.ContentType == ActivityContentType.AICC.ToString() && masteryScore.HasValue && tracking.RawScore.HasValue && masteryScore.Value != -1)
            {
                tracking.LessonStatus = (tracking.RawScore.Value >= masteryScore.Value) ? "passed" : "failed";
            }

            //when taking course not for credit, keep existing score/status/time, or if none exists, use "browsed"/null/zero time
            if (browseMode || !forCredit)
            {
                tracking.LessonStatus = currentStatus;
                tracking.RawScore = currentScore;
                tracking.TotalTime = totalTime;
            }
            else
            {
                tracking.TotalTime = tracking.SessionTime.HasValue ? tracking.SessionTime.Value + totalTime : totalTime;
            }

            contModTracking.LessonTracking[tracking.Identifier] = tracking;
            contModTracking.Bookmark = tracking.Identifier;

            return SetContentModuleTracking(contModTracking);
        }

        private ContentModuleTracking SetContentModuleTracking(ContentModuleTracking contModTracking)
        {
            var scos = contModTracking.LessonTracking;

            Func<LessonTracking, bool> lessonIsComplete = l => l.IsComplete;

            int numberOfPagesCompleted = scos.Values.Count(lessonIsComplete);

            contModTracking.NoOfPagesCompleted = numberOfPagesCompleted;

            if (numberOfPagesCompleted == contModTracking.TotalNoOfPages && !contModTracking.IsCompleted())
            {
                contModTracking.DateOfCompletion = DateTime.Now;
                contModTracking.CompletionStatus = ActivityCompletionStatus.Completed;
                var lastScore = scos.Select(sco => sco.Value.RawScore).LastOrDefault(score => score.HasValue);
                if (lastScore == null)
                {
                    contModTracking.Score = null;
                }
                else
                {
                    contModTracking.Score = Math.Round(lastScore.GetValueOrDefault(100)).ToString("F0");
                }
            }
            else
            {
                contModTracking.CompletionStatus = ActivityCompletionStatus.Started;

                var lastScore = scos.Select(sco => sco.Value.RawScore).LastOrDefault(score => score.HasValue);
                //contModTracking.Score = Math.Round(lastScore.GetValueOrDefault(100)).ToString("F0");
                if (lastScore == null)
                {
                    contModTracking.Score = null;
                }
                else
                {
                    contModTracking.Score = Math.Round(lastScore.GetValueOrDefault(100)).ToString("F0");
                }
            }

            return contModTracking;
        }
    }
}
