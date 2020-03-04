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
	objData:	{"a":[0,32,0,[-0.5000000000012506,-0.4999999999974989,1009,608]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 1009 45\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(504.5 22.5)\" style=\"\">\n	<path d=\"M 0 0 L 1009 0 L 1009 45 L 0 45 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-504.5, -22.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(504.5 22.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 2.73559e-12px; width: 1009px; height: 45px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,2.7355895326763857e-12,1009,45]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.000000000002736,1007,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 25px; top: 554px; width: 34px; height: 34px; z-index: 25; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page148387.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[25,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
progress70386.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 306px; height: 6px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 306px; height: 4px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 226px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 351px; top: 571px; width: 308px; height: 6px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[351,571,308,6]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":22,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 97px; width: 903px; height: 27px; z-index: 27;",
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
	cssText:	"visibility: inherit; position: absolute; left: 10px; top: 10px; width: 28px; height: 25px; z-index: 28; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 1047px; top: 0px; width: 1009px; height: 608px; z-index: 29;",
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
	cssText:	"visibility: inherit; position: absolute; left: 1450px; top: 139px; width: 373px; height: 373px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[1450,139,373,373]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
button148762.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148762Img\" src=\"images/next-close.png\" style=\"position: absolute; left: 0px; top: 0px; width: 34px; height: 34px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 948px; top: 554px; width: 34px; height: 34px; z-index: 31; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj148762",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next-close",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page148159.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[948,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next-close.png","resClick":"images/next-close.png","resOver":"images/next-close-H.png"}
};
text146172.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 904px; min-height: 75px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 904px; min-height: 75px;\"><p style=\"text-align: left; font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span id=\"trivUnsetLiStyle\" style=\"font-weight: normal; font-style: normal; color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Om te weten of je kuikens voldoende water binnen krijgen moet&nbsp;je de watergift en de&nbsp;waterdruk van de verschillende drinklijnen in de stal regelmatig controleren.&nbsp;Je beoordeelt de&nbsp;doorstroomsnelheid door een bekertje een minuut tegen een nippel te houden.</span></p><p style=\"text-align: left; font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span id=\"trivUnsetLiStyle\" style=\"font-weight: normal; font-style: normal; color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Een vuistregel voor de juiste doorstroomsnelheid is de leeftijd </span><span style=\"font-weight: normal; font-style: normal; color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">van de kuikens in dagen plus&nbsp;20 ml/min.</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 125px; width: 904px; height: 75px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj146172",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 6"
	},
	objData:	{"a":[0,32,0,[50,125,904,75]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":904,"height":75},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145727.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 142px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 142px; min-height: 25px;\"><p style=\"text-align:left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">10 dagen</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 81px; top: 263px; width: 142px; height: 25px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj145727",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1"
	},
	objData:	{"a":[0,32,0,[81,263,142,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":81,"y":263,"width":142,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145728.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 142px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 142px; min-height: 25px;\"><p style=\"text-align:left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">20 dagen</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 81px; top: 292px; width: 142px; height: 25px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj145728",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2"
	},
	objData:	{"a":[0,32,0,[81,292,142,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":81,"y":292,"width":142,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145732.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 142px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 142px; min-height: 25px;\"><p style=\"text-align:left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">30 dagen</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 81px; top: 322px; width: 142px; height: 25px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj145732",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3"
	},
	objData:	{"a":[0,32,0,[81,322,142,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":81,"y":322,"width":142,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145736.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 142px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 142px; min-height: 25px;\"><p style=\"text-align:left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">40 dagen</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 81px; top: 352px; width: 142px; height: 25px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj145736",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4"
	},
	objData:	{"a":[0,32,0,[81,352,142,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":81,"y":352,"width":142,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
qu145713.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu145713",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"",
				"questType":	2,
				"dwQuestFlags":	0,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0043"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"varQuest":	VarQuestion_145713
	},
	objData:	{"a":[0,32,0,[]]}
};
text145718.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 904px; min-height: 41px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 904px; min-height: 41px;\"><p align=\"left\"><span><strong><span style=\"color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Stel dat iemand een beker van 100 ml heeft&nbsp;en het duurt 2 minuten om het bekertje vol te krijgen. Voor welke leeftijd is dit dan de juiste doorloopsnelheid? </span></strong></span></p></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 218px; width: 904px; height: 41px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj145718",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[50,218,904,41]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":218,"width":904,"height":41},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145719.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 21px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 21px; min-height: 20px;\"><label for=\"rad145720\" style=\"cursor:\"><p align=\"left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">A</span></p></label></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 80px; top: 262px; width: 21px; height: 20px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj145719",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 1 text"
	},
	objData:	{"a":[0,0,0,[80,262,21,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":80,"y":262,"width":21,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
radio145720.rcdData.att_Desktop = 
{
	innerHtml:	"<div style=\"white-space: nowrap; position: absolute; left: 0px; top: 0px; width: 19px; height: 19px;\"><input type=\"radio\" id=\"rad145720\" name=\"rad145713\" value=\"A\" onclick=\"VarQuestion_145713.set(this.value);qu145713.questionUpdated();radio145720.issueActions(12);\" style=\"cursor: pointer; background-image: url(&quot;images/trivantis-blank.gif&quot;);\"></div>",
	cssText:	"visibility: inherit; position: absolute; left: 51px; top: 262px; width: 19px; height: 19px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj145720",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 1 button",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og139549.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[51,262,19,19]],"rcdOvr":{"res":0},"desktopRect":{"x":51,"y":262,"width":19,"height":19},"formType":1,"dwFormFlags":0}
};
text145721.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 21px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 21px; min-height: 20px;\"><label for=\"rad145722\" style=\"cursor:\"><p align=\"left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">B</span></p></label></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 80px; top: 292px; width: 21px; height: 20px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj145721",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 2 text"
	},
	objData:	{"a":[0,0,0,[80,292,21,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":80,"y":292,"width":21,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
radio145722.rcdData.att_Desktop = 
{
	innerHtml:	"<div style=\"white-space: nowrap; position: absolute; left: 0px; top: 0px; width: 19px; height: 19px;\"><input type=\"radio\" id=\"rad145722\" name=\"rad145713\" value=\"B\" onclick=\"VarQuestion_145713.set(this.value);qu145713.questionUpdated();radio145722.issueActions(12);\" style=\"cursor: pointer; background-image: url(&quot;images/trivantis-blank.gif&quot;);\"></div>",
	cssText:	"visibility: inherit; position: absolute; left: 51px; top: 292px; width: 19px; height: 19px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj145722",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 2 button",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og139549.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[51,292,19,19]],"rcdOvr":{"res":0},"desktopRect":{"x":51,"y":292,"width":19,"height":19},"formType":1,"dwFormFlags":0}
};
text145723.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 22px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 22px; min-height: 20px;\"><label for=\"rad145724\" style=\"cursor:\"><p align=\"left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">C</span></p></label></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 80px; top: 322px; width: 22px; height: 20px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj145723",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 3 text"
	},
	objData:	{"a":[0,0,0,[80,322,22,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":80,"y":322,"width":22,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
radio145724.rcdData.att_Desktop = 
{
	innerHtml:	"<div style=\"white-space: nowrap; position: absolute; left: 0px; top: 0px; width: 19px; height: 19px;\"><input type=\"radio\" id=\"rad145724\" name=\"rad145713\" value=\"C\" onclick=\"VarQuestion_145713.set(this.value);qu145713.questionUpdated();radio145724.issueActions(12);\" style=\"cursor: pointer; background-image: url(&quot;images/trivantis-blank.gif&quot;);\"></div>",
	cssText:	"visibility: inherit; position: absolute; left: 51px; top: 322px; width: 19px; height: 19px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj145724",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 3 button",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og139549.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[51,322,19,19]],"rcdOvr":{"res":0},"desktopRect":{"x":51,"y":322,"width":19,"height":19},"formType":1,"dwFormFlags":0}
};
text145725.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 22px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 22px; min-height: 20px;\"><label for=\"rad145726\" style=\"cursor:\"><p align=\"left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">D</span></p></label></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 80px; top: 352px; width: 22px; height: 20px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj145725",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 4 text"
	},
	objData:	{"a":[0,0,0,[80,352,22,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":80,"y":352,"width":22,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
radio145726.rcdData.att_Desktop = 
{
	innerHtml:	"<div style=\"white-space: nowrap; position: absolute; left: 0px; top: 0px; width: 19px; height: 19px;\"><input type=\"radio\" id=\"rad145726\" name=\"rad145713\" value=\"D\" onclick=\"VarQuestion_145713.set(this.value);qu145713.questionUpdated();radio145726.issueActions(12);\" style=\"cursor: pointer; background-image: url(&quot;images/trivantis-blank.gif&quot;);\"></div>",
	cssText:	"visibility: inherit; position: absolute; left: 51px; top: 352px; width: 19px; height: 19px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj145726",
	bInsAnc:	0,
	fieldsetId:	'fset145713',
	cwObj:		{
		"name":	"Choice 4 button",
		"arChld":
	[
		{type:6,on:12,delay:0,name:'OnSelectChangeHide',actItem:function(){ og139549.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[0,32,0,[51,352,19,19]],"rcdOvr":{"res":0},"desktopRect":{"x":51,"y":352,"width":19,"height":19},"formType":1,"dwFormFlags":0}
};
button139372.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj139372Img\" src=\"images/btn-submit.png\" style=\"position: absolute; left: 0px; top: 0px; width: 167px; height: 30px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 53px; top: 400px; width: 167px; height: 30px; z-index: 32; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj139372",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-submit",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkRunActGrp',actItem:function(){ if(!VarQuestion_145713.equals('~~~null~~~')){og140258.issueActions(1001);}else if(typeof pF == 'function') pF();
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[53,400,167,30]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":53,"y":400,"width":167,"height":30},"res":"images/btn-submit.png","resClick":"images/btn-submit.png","resOver":"images/btn-submit-H.png"}
};
og139549.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og139549",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text139550.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 900px; height: 50px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 892px; height: 42px;\"><p><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Dit is niet correct, lees de vuistregel nog eens goed en probeer het n</span><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">og een keer.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 464px; width: 900px; height: 50px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj139550",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB1"
	},
	objData:	{"a":[0,0,0,[50,464,900,50]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":464,"width":900,"height":50},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text143596.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 910px; height: 50px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 902px; height: 42px;\"><p style=\"text-align:left\"><span style=\"color: rgb(0, 158, 15); font-family: calibri; font-size:12pt;\">Correct.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 464px; width: 910px; height: 50px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj143596",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB2"
	},
	objData:	{"a":[0,0,0,[50,464,910,50]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":464,"width":910,"height":50},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
og140258.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og140258",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
rcdObj.rcdData.att_Desktop = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	22
};
rcdObj.pgWidth_Desktop = pgWidth_desktop;
rcdObj.preload_Desktop = ["images/prev.png","images/prevHover.png","images/btn-submit.png","images/btn-submit-H.png","images/indicatie.gif","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/next-close.png","images/next-close-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png"];
rcdObj.pgStyle_Desktop = 'position: absolute; left: 0px; top: 0px; width: 1009px; height: 609px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_Desktop = ["#eeeeee","",0,0,1];
