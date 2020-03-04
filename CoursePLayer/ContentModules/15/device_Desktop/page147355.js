if (window.VarCurrentView) VarCurrentView.set('Desktop');
function init_Desktop() {
	if ( rcdObj.view != 'Desktop' ) return;
	if (!isOPAPub() || isLOPopup()) window.init_page();
	preload(rcdObj['preload_'+rcdObj.view]);
}
function defineFuncs_Desktop() {
	if ( rcdObj.view != 'Desktop' ) return;
	try{
		if (window.initGEV)
		{
		 initGEV(0,swipeLeft,swipeRight);
	swipeLeft = function(){
		try {action31985()} catch(e){}
	}
	swipeRight = function(){
		try {action137336()} catch(e){}
	}
		initGEV(1,swipeLeft,swipeRight);

		}
		} catch(e) { if (window.console) window.console.log(e); }	pageClick = n;
	pageRClick = n;
	pageKey = n;
	pageKey = function(e,keyVal,keyFlags) {
		var keyAvail = true;
		if( keyFlags == 0 && keyVal == 39 ){action137338(); keyAvail = false; };

    if( keyFlags == 0 && keyVal == 37 ){action137337(); keyAvail = false; };

		return keyAvail;
	};
}
og148932.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148932",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
og28117.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og28117",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape146877.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 1009 608\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(504.5 304)\" style=\"\">\n	<path d=\"M 0 0 L 1008 0 L 1008 607 L 0 607 L 0 0 Z\" style=\"stroke: rgb(219, 102, 39); stroke-width: 1; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-504, -303.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(504.5 304)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: -0.5px; top: -0.5px; width: 1009px; height: 608px; z-index: 1; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj146877",
	bInsAnc:	0,
	cwObj:		{
		"name":	"kaderlijn"
	},
	objData:	{"a":[0,32,0,[-0.5000000000006821,-0.49999999999863576,1009,608]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 1009 45\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(504.5 22.5)\" style=\"\">\n	<path d=\"M 0 0 L 1009 0 L 1009 45 L 0 45 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-504.5, -22.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(504.5 22.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.49214e-12px; width: 1009px; height: 45px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.4921397450962104e-12,1009,45]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137498.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 1007 34\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(503.5 17)\" style=\"\">\n	<path d=\"M 0 0 L 1007 0 L 1007 34 L 0 34 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-503.5, -17) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(503.5 17)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 1px; top: 45px; width: 1007px; height: 34px; z-index: 3; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137498",
	bInsAnc:	0,
	cwObj:		{
		"name":	"subheaderbackground"
	},
	objData:	{"a":[0,160,0,[1,45.00000000000149,1007,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
button146730.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj146730Img\" src=\"images/btn-close143187.png\" style=\"position: absolute; left: 0px; top: 0px; width: 20px; height: 20px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 975px; top: 14px; width: 20px; height: 20px; z-index: 4; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146730",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-close",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkExitClose',actItem:function(){ {trivScormQuit(false, 'page1.html', true);} 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,288,0,[975,14,20,20]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":975,"y":14,"width":20,"height":20},"res":"images/btn-close143187.png","resClick":"images/btn-close143187.png","resOver":"images/btn-close-hover143188.png"}
};
image147010.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj147010Img\" src=\"images/logo-roodbont.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 135px; height: 21px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 852px; top: 52px; width: 135px; height: 21px; z-index: 5;",
	cssClasses:	"",
	htmlId:		"tobj147010",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-roodbont"
	},
	objData:	{"a":[0,256,0,[852,52,135,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":852,"y":52,"width":135,"height":21}}
};
image148817.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148817Img\" src=\"images/logo-Aeres.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 140px; height: 61px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 826px; top: 9px; width: 140px; height: 61px; z-index: 6;",
	cssClasses:	"",
	htmlId:		"tobj148817",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-Aeres"
	},
	objData:	{"a":[0,288,0,[826,9,140,61]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":826,"y":9,"width":140,"height":61}}
};
button352.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj352Img\" src=\"images/prev.png\" style=\"position: absolute; left: 0px; top: 0px; width: 34px; height: 34px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 25px; top: 554px; width: 34px; height: 34px; z-index: 28; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144786.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[25,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 34px; height: 34px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 948px; top: 554px; width: 34px; height: 34px; z-index: 29; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144805.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[948,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 306px; height: 6px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 306px; height: 4px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 123px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 351px; top: 571px; width: 308px; height: 6px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[351,571,308,6]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":12,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
};
text354.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 860px; min-height: 40px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 860px; min-height: 40px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span><strong><span style=\"font-size:22pt; color: rgb(255, 255, 255); font-family: calibri;\">Vleeskuikensignalen -&nbsp;</span></strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:22pt;\">Water en strooisel</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 5px; width: 860px; height: 40px; z-index: 7;",
	cssClasses:	"",
	htmlId:		"tobj354",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Title module"
	},
	objData:	{"a":[0,32,0,[50,5,860,40]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":5,"width":860,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146550.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 900px; min-height: 34px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 900px; min-height: 34px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span style=\"font-size:18pt; color: rgb(102, 102, 102); font-family: calibri;\">Title of chapter</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 47px; width: 900px; height: 34px; z-index: 8;",
	cssClasses:	"",
	htmlId:		"tobj146550",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Title of Chapter",
		"arChld":
	[
		{type:6,on:11,delay:0,name:'OnPageShowChange',actItem:function(){ text146550.changeContents(VarCurrentChapterName.getValue()); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[50,47,900,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":47,"width":900,"height":34},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146548.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 903px; min-height: 27px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 903px; min-height: 27px;\"><p leglh=\"1.218\" style=\"margin-left:0px;text-indent:0px;line-height:1.218;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span style=\"font-size:14pt; font-family: calibri;\"><strong><span style=\"color: rgb(0, 0, 0);\">Title of Page</span></strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000; \"><strong> </strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000;\"> </span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 97px; width: 903px; height: 27px; z-index: 31;",
	cssClasses:	"",
	htmlId:		"tobj146548",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Title of Page",
		"arChld":
	[
		{type:6,on:11,delay:0,name:'OnPageShowChange',actItem:function(){ text146548.changeContents(VarCurrentPageName.getValue()); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,96,0,[50,97,903,27]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":97,"width":903,"height":27},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148245.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148245Img\" src=\"images/btn-home.png\" style=\"position: absolute; left: 0px; top: 0px; width: 28px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 10px; top: 10px; width: 28px; height: 25px; z-index: 32; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj148245",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-home",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page148159.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[10,10,28,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":10,"y":10,"width":28,"height":25},"res":"images/btn-home.png","resClick":"images/btn-home.png","resOver":"images/btn-home-H.png"}
};
og148948.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148948",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape148949.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"visibility: inherit; position: absolute; left: 1047px; top: 0px; width: 1009px; height: 608px; z-index: 33;",
	cssClasses:	"",
	htmlId:		"tobj148949",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,16480,0,[1047,0,1009,608]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1047,"y":0,"width":1009,"height":608}}
};
image148950.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"visibility: inherit; position: absolute; left: 1450px; top: 139px; width: 373px; height: 373px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[1450,139,373,373]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
qu147506.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu147506",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"",
				"questType":	2,
				"dwQuestFlags":	65544,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0047\\u006F\\u0065\\u0064"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"varQuest":	VarQuestion_1B
	},
	objData:	{"a":[0,32,0,[]]}
};
text147511.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 113px; min-height: 20px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 113px; min-height: 20px;\"><label for=\"frmobj147512\" style=\"cursor:\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\">Helderheid:</span></p></label></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 413px; width: 113px; height: 20px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj147511",
	bInsAnc:	0,
	fieldsetId:	'fset147506',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[50,413,113,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":413,"width":113,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
combo147512.rcdData.att_Desktop = 
{
	innerHtml:	"<select name=\"Question Drop List\" id=\"frmobj147512\" title=\"Question Drop List\" onchange=\"qu147506.questionUpdated(this);combo147512.issueActions(12);\" style=\"font-size: 12pt; font-family: Calibri; color: rgb(0, 0, 0); padding: 0px; background-color: rgb(255, 255, 255); position: absolute; left: 0px; top: 0px; width: 160px; height: 22px; cursor: pointer;\"><option value=\"Goed\" label=\"Goed\">Goed</option><option value=\"Matig\" label=\"Matig\">Matig</option><option value=\"Slecht\" label=\"Slecht\">Slecht</option></select>",
	cssText:	"visibility: inherit; position: absolute; left: 135px; top: 412px; width: 160px; height: 22px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj147512",
	bInsAnc:	0,
	fieldsetId:	'fset147506',
	cwObj:		{
		"name":	"Question Drop List",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og147418.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[135,412,160,22]],"rcdOvr":{"res":0},"desktopRect":{"x":135,"y":412,"width":160,"height":22},"formType":3,"dwFormFlags":0}
};
qu147481.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu147481",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"",
				"questType":	2,
				"dwQuestFlags":	65544,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0047\\u006F\\u0065\\u0064\\u0020"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"varQuest":	VarQuestion_1A
	},
	objData:	{"a":[0,32,0,[]]}
};
text147486.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 113px; min-height: 20px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 113px; min-height: 20px;\"><label for=\"frmobj147516\" style=\"cursor:\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\">Kleur:</span></p></label></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 380px; width: 113px; height: 20px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj147486",
	bInsAnc:	0,
	fieldsetId:	'fset147481',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[50,380,113,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":380,"width":113,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
combo147516.rcdData.att_Desktop = 
{
	innerHtml:	"<select name=\"Question Drop List\" id=\"frmobj147516\" title=\"Question Drop List\" onchange=\"qu147481.questionUpdated(this);combo147516.issueActions(12);\" style=\"font-size: 12pt; font-family: Calibri; color: rgb(0, 0, 0); padding: 0px; background-color: rgb(255, 255, 255); position: absolute; left: 0px; top: 0px; width: 160px; height: 22px; cursor: pointer;\"><option value=\"Goed \" label=\"Goed \">Goed </option><option value=\"Matig\" label=\"Matig\">Matig</option><option value=\"Slecht\" label=\"Slecht\">Slecht</option></select>",
	cssText:	"visibility: inherit; position: absolute; left: 100px; top: 380px; width: 160px; height: 22px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj147516",
	bInsAnc:	0,
	fieldsetId:	'fset147481',
	cwObj:		{
		"name":	"Question Drop List",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og147418.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[100,380,160,22]],"rcdOvr":{"res":0},"desktopRect":{"x":100,"y":380,"width":160,"height":22},"formType":3,"dwFormFlags":0}
};
qu147523.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu147523",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"",
				"questType":	2,
				"dwQuestFlags":	65544,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0053\\u006C\\u0065\\u0063\\u0068\\u0074"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"varQuest":	VarQuestion_2B
	},
	objData:	{"a":[0,32,0,[]]}
};
text147524.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 113px; min-height: 20px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 113px; min-height: 20px;\"><label for=\"frmobj147525\" style=\"cursor:\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\">Helderheid:</span></p></label></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 355px; top: 413px; width: 113px; height: 20px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj147524",
	bInsAnc:	0,
	fieldsetId:	'fset147523',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[355,413,113,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":355,"y":413,"width":113,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
combo147525.rcdData.att_Desktop = 
{
	innerHtml:	"<select name=\"Question Drop List\" id=\"frmobj147525\" title=\"Question Drop List\" onchange=\"qu147523.questionUpdated(this);combo147525.issueActions(12);\" style=\"font-size: 12pt; font-family: Calibri; color: rgb(0, 0, 0); padding: 0px; background-color: rgb(255, 255, 255); position: absolute; left: 0px; top: 0px; width: 160px; height: 22px; cursor: pointer;\"><option value=\"Goed\" label=\"Goed\">Goed</option><option value=\"Matig\" label=\"Matig\">Matig</option><option value=\"Slecht\" label=\"Slecht\">Slecht</option></select>",
	cssText:	"visibility: inherit; position: absolute; left: 440px; top: 412px; width: 160px; height: 22px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj147525",
	bInsAnc:	0,
	fieldsetId:	'fset147523',
	cwObj:		{
		"name":	"Question Drop List",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og147418.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[440,412,160,22]],"rcdOvr":{"res":0},"desktopRect":{"x":440,"y":412,"width":160,"height":22},"formType":3,"dwFormFlags":0}
};
qu147520.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu147520",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"",
				"questType":	2,
				"dwQuestFlags":	65544,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0053\\u006C\\u0065\\u0063\\u0068\\u0074"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"varQuest":	VarQuestion_2A
	},
	objData:	{"a":[0,32,0,[]]}
};
text147521.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 113px; min-height: 20px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 113px; min-height: 20px;\"><label for=\"frmobj147522\" style=\"cursor:\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\">Kleur:</span></p></label></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 355px; top: 380px; width: 113px; height: 20px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj147521",
	bInsAnc:	0,
	fieldsetId:	'fset147520',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[355,380,113,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":355,"y":380,"width":113,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
combo147522.rcdData.att_Desktop = 
{
	innerHtml:	"<select name=\"Question Drop List\" id=\"frmobj147522\" title=\"Question Drop List\" onchange=\"qu147520.questionUpdated(this);combo147522.issueActions(12);\" style=\"font-size: 12pt; font-family: Calibri; color: rgb(0, 0, 0); padding: 0px; background-color: rgb(255, 255, 255); position: absolute; left: 0px; top: 0px; width: 160px; height: 22px; cursor: pointer;\"><option value=\"Goed \" label=\"Goed \">Goed </option><option value=\"Matig\" label=\"Matig\">Matig</option><option value=\"Slecht\" label=\"Slecht\">Slecht</option></select>",
	cssText:	"visibility: inherit; position: absolute; left: 405px; top: 380px; width: 160px; height: 22px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj147522",
	bInsAnc:	0,
	fieldsetId:	'fset147520',
	cwObj:		{
		"name":	"Question Drop List",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og147418.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[405,380,160,22]],"rcdOvr":{"res":0},"desktopRect":{"x":405,"y":380,"width":160,"height":22},"formType":3,"dwFormFlags":0}
};
qu147540.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu147540",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"",
				"questType":	2,
				"dwQuestFlags":	65544,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0047\\u006F\\u0065\\u0064"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"varQuest":	VarQuestion_3B
	},
	objData:	{"a":[0,32,0,[]]}
};
text147541.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 113px; min-height: 20px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 113px; min-height: 20px;\"><label for=\"frmobj147542\" style=\"cursor:\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\">Helderheid:</span></p></label></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 660px; top: 413px; width: 113px; height: 20px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj147541",
	bInsAnc:	0,
	fieldsetId:	'fset147540',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[660,413,113,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":660,"y":413,"width":113,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
combo147542.rcdData.att_Desktop = 
{
	innerHtml:	"<select name=\"Question Drop List\" id=\"frmobj147542\" title=\"Question Drop List\" onchange=\"qu147540.questionUpdated(this);combo147542.issueActions(12);\" style=\"font-size: 12pt; font-family: Calibri; color: rgb(0, 0, 0); padding: 0px; background-color: rgb(255, 255, 255); position: absolute; left: 0px; top: 0px; width: 160px; height: 22px; cursor: pointer;\"><option value=\"Goed\" label=\"Goed\">Goed</option><option value=\"Matig\" label=\"Matig\">Matig</option><option value=\"Slecht\" label=\"Slecht\">Slecht</option></select>",
	cssText:	"visibility: inherit; position: absolute; left: 745px; top: 412px; width: 160px; height: 22px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj147542",
	bInsAnc:	0,
	fieldsetId:	'fset147540',
	cwObj:		{
		"name":	"Question Drop List",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og147418.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[745,412,160,22]],"rcdOvr":{"res":0},"desktopRect":{"x":745,"y":412,"width":160,"height":22},"formType":3,"dwFormFlags":0}
};
qu147537.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu147537",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"",
				"questType":	2,
				"dwQuestFlags":	65544,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0053\\u006C\\u0065\\u0063\\u0068\\u0074"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"varQuest":	VarQuestion_3A
	},
	objData:	{"a":[0,32,0,[]]}
};
text147538.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 113px; min-height: 20px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 113px; min-height: 20px;\"><label for=\"frmobj147539\" style=\"cursor:\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\">Kleur:</span></p></label></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 660px; top: 380px; width: 113px; height: 20px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj147538",
	bInsAnc:	0,
	fieldsetId:	'fset147537',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[660,380,113,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":660,"y":380,"width":113,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
combo147539.rcdData.att_Desktop = 
{
	innerHtml:	"<select name=\"Question Drop List\" id=\"frmobj147539\" title=\"Question Drop List\" onchange=\"qu147537.questionUpdated(this);combo147539.issueActions(12);\" style=\"font-size: 12pt; font-family: Calibri; color: rgb(0, 0, 0); padding: 0px; background-color: rgb(255, 255, 255); position: absolute; left: 0px; top: 0px; width: 160px; height: 22px; cursor: pointer;\"><option value=\"Goed \" label=\"Goed \">Goed </option><option value=\"Matig\" label=\"Matig\">Matig</option><option value=\"Slecht\" label=\"Slecht\">Slecht</option></select>",
	cssText:	"visibility: inherit; position: absolute; left: 710px; top: 380px; width: 160px; height: 22px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj147539",
	bInsAnc:	0,
	fieldsetId:	'fset147537',
	cwObj:		{
		"name":	"Question Drop List",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og147418.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[710,380,160,22]],"rcdOvr":{"res":0},"desktopRect":{"x":710,"y":380,"width":160,"height":22},"formType":3,"dwFormFlags":0}
};
button147421.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj147421Img\" src=\"images/btn-submit.png\" style=\"position: absolute; left: 0px; top: 0px; width: 167px; height: 30px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 452px; width: 167px; height: 30px; z-index: 35; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147421",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-submit",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkModVar',actItem:function(){ if(!VarQuestion_1A.isCorr('\u0047\u006F\u0065\u0064\u0020')||!VarQuestion_1B.isCorr('\u0047\u006F\u0065\u0064')||!VarQuestion_2A.isCorr('\u0053\u006C\u0065\u0063\u0068\u0074')||!VarQuestion_2B.isCorr('\u0053\u006C\u0065\u0063\u0068\u0074')||!VarQuestion_3A.isCorr('\u0053\u006C\u0065\u0063\u0068\u0074')||!VarQuestion_3B.isCorr('\u0047\u006F\u0065\u0064'))VarAttempts.add('1'); else if(typeof pF == 'function') pF();
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkRunActGrp',actItem:function(){ if(!VarQuestion_1A.equals('~~~null~~~')){og147412.issueActions(1001);}else if(typeof pF == 'function') pF();
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[50,452,167,30]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":452,"width":167,"height":30},"res":"images/btn-submit.png","resClick":"images/btn-submit.png","resOver":"images/btn-submit-H.png"}
};
og147418.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147418",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text147419.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 716px; height: 90px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 708px; height: 82px;\"><p><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Dit is niet correct.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 242px; top: 451px; width: 716px; height: 90px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj147419",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB1"
	},
	objData:	{"a":[0,0,0,[242,451,716,90]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":242,"y":451,"width":716,"height":90},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text148961.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 716px; height: 90px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 708px; height: 82px;\"><p><span style=\"font-family: calibri; color: rgb(207, 42, 39); font-size:12pt;\">Niet correct. Het juiste antwoord is:</span></p>\n\n<p><span style=\"font-family: calibri; color: rgb(207, 42, 39); font-size:12pt;\">Foto 1: kleur goed, helderheid goed.</span></p>\n\n<p><span style=\"font-family: calibri; color: rgb(207, 42, 39); font-size:12pt;\">Foto 2: kleur slecht, helderheid slecht.</span></p>\n\n<p><span style=\"font-family: calibri; color: rgb(207, 42, 39); font-size:12pt;\">Foto 3: kleur slecht, helderheid goed.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 242px; top: 451px; width: 716px; height: 90px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj148961",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB2",
		"arChld":
	[
		{type:6,on:5,delay:0,name:'OnShowModVar',actItem:function(){ VarAttempts.set('0'); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[32,0,0,[242,451,716,90]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":242,"y":451,"width":716,"height":90},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147420.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 716px; height: 90px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 708px; height: 82px;\"><p style=\"text-align:left\"><span style=\"color: rgb(0, 158, 15); font-family: calibri; font-size:12pt;\">Correct.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 242px; top: 451px; width: 716px; height: 90px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj147420",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB3"
	},
	objData:	{"a":[0,0,0,[242,451,716,90]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":242,"y":451,"width":716,"height":90},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
og147412.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147412",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
og147385.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147385",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
og147381.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147381",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
image147383.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj147383Img\" src=\"images/watertest1.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 290px; height: 217px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 153px; width: 290px; height: 217px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj147383",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest1"
	},
	objData:	{"a":[0,288,0,[50,153,290,217]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":153,"width":290,"height":217}}
};
image147387.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj147387Img\" src=\"images/watertest5.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 290px; height: 217px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 354px; top: 150px; width: 290px; height: 217px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj147387",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest5"
	},
	objData:	{"a":[0,288,0,[354,150,290,217]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":354,"y":150,"width":290,"height":217}}
};
image147391.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj147391Img\" src=\"images/watertest4.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 290px; height: 217px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 660px; top: 150px; width: 290px; height: 217px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj147391",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest4"
	},
	objData:	{"a":[0,288,0,[660,150,290,217]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":660,"y":150,"width":290,"height":217}}
};
text147397.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 818px; min-height: 52px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 818px; min-height: 52px;\"><p><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Beoordeel de onderstaande foto\'s op kleur en helderheid.&nbsp;</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 127px; width: 818px; height: 52px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj147397",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[50,127,818,52]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":127,"width":818,"height":52},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_Desktop = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	12
};
rcdObj.pgWidth_Desktop = pgWidth_desktop;
rcdObj.preload_Desktop = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/btn-submit.png","images/btn-submit-H.png","images/indicatie.gif","images/watertest1.jpg","images/watertest4.jpg","images/watertest5.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png"];
rcdObj.pgStyle_Desktop = 'position: absolute; left: 0px; top: 0px; width: 1009px; height: 609px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_Desktop = ["#eeeeee","",0,0,1];
