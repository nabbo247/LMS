function fValidateLookup(lVal, lLookup) {
    var sRetVal = gScormLookups[lLookup + "__" + lVal];
    if (!fIsUndefined(sRetVal)) {
        return true;
    }

    sRetVal = gScormLookups[lLookup + "__CheckFor"];
    if (!fIsUndefined(sRetVal)) {
        if (fExtResValidate(sRetVal, lVal, "", "", "")) {
            return true;
        }
    }

    return false;
}

function fExtResValidate(lValidationType, strValue, lVocLookup, LValue, HValue) {
    var StringValue = strValue.toString();

    switch (lValidationType.toUpperCase()) {
    case "CMIBLANK":
        if (StringValue.length > 0) {
            return false;
        }
        break;
    case "CMIBOOLEAN":
        if (!(StringValue == "true" || StringValue == "false")) {
            return false;
        }
        break;
    case "CMIDECIMAL":
        if (!isSignedFloat(StringValue)) {
            return false;
        }
        break;
    case "CMIIDENTIFIER":

        if (StringValue.length > 255) {
            return false;
        }
        if (!( /^[\w\d\.]+$/ .test(StringValue))) {
            return false;
        }
        break;
    case "CMIINTEGER":
        if (!(isInteger(StringValue))) {
            return false;
        }

        strValue = parseInt(strValue);
        if (strValue < 0 || strValue > 65536) {
            return false;
        }
        break;
    case "CMISINTEGER":
        if (!(isSignedInteger(StringValue))) {
            return false;
        }

        strValue = parseInt(strValue);
        if (strValue < -32768 || strValue > 32768 || strValue > parseInt(HValue) || strValue < parseInt(LValue)) {
            return false;
        }
        break;
    case "CMISTRING255":
        if (StringValue.length > 255) {
            return false;
        }
        break;
    case "CMISTRING4096":
        if (StringValue.length > 4096) {
            return false;
        }
        break;
    case "CMITIME":
        if (!(fCheckCMITime(StringValue))) {
            return false;
        }
        break;
    case "CMITIMESPAN":
        if (!(fCheckCMITimeSpan(StringValue))) {
            return false;
        }
        break;
    case "CMIVOCABULARY":
        if (!fValidateLookup(StringValue, lVocLookup)) {
            return false;
        }
        break;
    }
    return true;
}

function fCheckCMITime(StringValue){
   var tmp=StringValue.split(':');
   if (tmp.length != 3 || tmp[0].length != 2 || tmp[1].length != 2){
      return false;
   }
   if (!(fCheckTimeSpan(StringValue, 24))){
      return false;
   }
   
   return true;
}

function fCheckCMITimeSpan(StringValue){
   var tmp=StringValue.split(':');
   if (tmp.length != 3 || tmp[0].length < 2 || tmp[0].length > 4 || tmp[1].length != 2){
      return false;
   }
   if (!(fCheckTimeSpan(StringValue, 10000, true))){
      return false;
   }
   
   return true;
}

function fCheckTimeSpan(StringValue, maxHrs, lbTimeSpan) {
    var tmp = StringValue.split(':');
    var iMins;
    /********** valid hour **********************/
    var itm = parseInt(tmp[0]);
    if (isNaN(itm)) {
        return false;
    }

    /********** valid min *************************/
    if (itm >= 0 && itm < maxHrs) {
        itm = parseInt(tmp[1]);
        if (isNaN(itm)) {
            return false;
        }
        /******************** valid sec *****************/
        if (lbTimeSpan)
            iMins = 100; 						//to make scorm complient
        else
            iMins = 60;
        if (itm >= 0 && itm < iMins) {
            itm = tmp[2].indexOf('.');
            if (itm == -1) {
                itm = parseInt(tmp[2]);
                if (isNaN(tmp[2])) {
                    return false;
                }
                if (itm >= 0 && itm < 60)
                    return true;
            }
            else {
                if (itm == 2) {
                    tmp = tmp[2].split('.');
                    {
                        itm = parseInt(tmp[0]);
                        if (isNaN(tmp[0])) {
                            return false;
                        }
                        if (itm >= 0 && itm < 60) {
                            if (tmp[1].length > 2) {
                                return false;
                            }
                            itm = parseInt(tmp[1]);
                            if (isNaN(tmp[1])) {
                                return false;
                            }
                            if (itm >= 0 && itm <= 99)
                                return true;
                            else {
                                return false;
                            }
                        }
                    }
                }
            }
        }
    }
    return false;
}

var decimalPointDelimiter = ".";
var defaultEmptyOK = false;

function isInteger (s){
    var i;

    if (isEmpty(s))
       if (isInteger.arguments.length == 1) return defaultEmptyOK;
       else return (isInteger.arguments[1] == true);

    for (i = 0; i < s.length; i++)
    {
        // Check that current character is number.
        var c = s.charAt(i);

        if (!isDigit(c)) return false;
    }

    // All characters are numbers.
    return true;
}


function isEmpty(s){
    return ((s == null) || (s.length == 0));
}

function isSignedInteger (s){
    if (isEmpty(s))
       if (isSignedInteger.arguments.length == 1) return defaultEmptyOK;
       else return (isSignedInteger.arguments[1] == true);

    else {
        var startPos = 0;
        var secondArg = defaultEmptyOK;

        if (isSignedInteger.arguments.length > 1)
            secondArg = isSignedInteger.arguments[1];

        // skip leading + or -
        if ( (s.charAt(0) == "-") || (s.charAt(0) == "+") )
           startPos = 1;
        return (isInteger(s.substring(startPos, s.length), secondArg));
    }
}

function isDigit (c){
    return ((c >= "0") && (c <= "9"));
}

function isFloat (s){
    var i;
    var seenDecimalPoint = false;

    if (isEmpty(s))
       if (isFloat.arguments.length == 1) return defaultEmptyOK;
       else return (isFloat.arguments[1] == true);

    if (s == decimalPointDelimiter) return false;

    // Search through string's characters one by one
    // until we find a non-numeric character.
    // When we do, return false; if we don't, return true.

    for (i = 0; i < s.length; i++)
    {
        // Check that current character is number.
        var c = s.charAt(i);

        if ((c == decimalPointDelimiter) && !seenDecimalPoint) seenDecimalPoint = true;
        else if (!isDigit(c)) return false;
    }

    // All characters are numbers.
    return true;
}

function isSignedFloat (s){
    if (isEmpty(s))
       if (isSignedFloat.arguments.length == 1) return defaultEmptyOK;
       else return (isSignedFloat.arguments[1] == true);

    else {
        var startPos = 0;
        var secondArg = defaultEmptyOK;

        if (isSignedFloat.arguments.length > 1)
            secondArg = isSignedFloat.arguments[1];

        // skip leading + or -
        if ( (s.charAt(0) == "-") || (s.charAt(0) == "+") )
           startPos = 1;
        return (isFloat(s.substring(startPos, s.length), secondArg));
    }
}
