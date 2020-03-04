if (window.VarCurrentView) VarCurrentView.set('Desktop');
function init_Desktop() {
	if ( rcdObj.view != 'Desktop' ) return;
	if (!isOPAPub() || isLOPopup()) window.init_page();
	preload(rcdObj['preload_'+rcdObj.view]);
trivExitPage.trivExitPageItemExits=function(){
		trivCompleteCnt++;action149007( trivLeavePage );
		trivCompleteCnt++;action149012( trivLeavePage );
};
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
	objData:	{"a":[0,32,0,[-0.5000000000000568,-0.4999999999998863,1009,608]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 1009 45\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(504.5 22.5)\" style=\"\">\n	<path d=\"M 0 0 L 1009 0 L 1009 45 L 0 45 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-504.5, -22.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(504.5 22.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.24345e-13px; width: 1009px; height: 45px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.2434497875801753e-13,1009,45]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.00000000000013,1007,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
text354.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 860px; min-height: 40px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 860px; min-height: 40px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span><strong><span style=\"font-size:22pt; color: rgb(255, 255, 255); font-family: calibri;\">Vleeskuikensignalen -&nbsp;</span></strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:22pt;\">Water en strooisel</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 5px; width: 860px; height: 40px; z-index: 6;",
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
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 47px; width: 900px; height: 34px; z-index: 7;",
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
	cssText:	"visibility: inherit; position: absolute; left: 1047px; top: 0px; width: 1009px; height: 608px; z-index: 31;",
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
	cssText:	"visibility: inherit; position: absolute; left: 1450px; top: 139px; width: 373px; height: 373px; z-index: 32;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[1450,139,373,373]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
image148160.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148160Img\" src=\"images/kaft-water-en-strooisel.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 1008px; height: 567px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 1px; top: 42px; width: 1008px; height: 567px; z-index: 8;",
	cssClasses:	"",
	htmlId:		"tobj148160",
	bInsAnc:	0,
	cwObj:		{
		"name":	"kaft-water-en-strooisel"
	},
	objData:	{"a":[0,32,0,[1,42,1008,567]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":42,"width":1008,"height":567}}
};
shape148161.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 496 76\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(248 38)\" style=\"\">\n	<path d=\"M 7.88 0 L 488.12 0 A 7.88 7.88 0 0 1 496 7.88 L 496 68.12 A 7.88 7.88 0 0 1 488.12 76 L 7.88 76 A 7.88 7.88 0 0 1 0 68.12 L 0 7.88 A 7.88 7.88 0 0 1 7.88 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-248, -38) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(248 38)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 473px; top: 278px; width: 496px; height: 76px; z-index: 9; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148161",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rounded Rectangle"
	},
	objData:	{"a":[0,32,0,[473,278.00000000000006,496,76]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":473,"y":278,"width":496,"height":76},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148161.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
textbutton148162.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 352 42\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(176 21)\" style=\"\">\n	<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_1\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_1&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(176 21)\">\n		<text font-family=\"\'Calibri\'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 49px; top: 68px; width: 352px; height: 42px; z-index: 10; cursor: pointer; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148162",
	bInsAnc:	1,
	cwObj:		{
		"name":	"Button 1",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page137552.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,32800,0,[49,68.00000000000004,352,42]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":69,"width":352,"height":42},"imgDataNormal":"images/desktop_shape148162.png","imgDataOver":"images/desktop_shape148162_over.png","imgDataDown":"images/desktop_shape148162.png","imgDataDisabled":"images/desktop_shape148162_disabled.png","svgDataNormal":"<g transform=\"translate(176 21)\" style=\"\">\n\t<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_1\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_1&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<linearGradient id=\"SVGID_148159_2\" gradientUnits=\"userSpaceOnUse\" x1=\"0\" y1=\"0\" x2=\"0\" y2=\"42\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<g transform=\"translate(176 21)\" style=\"\">\n\t<linearGradient id=\"SVGID_148159_2\" gradientUnits=\"userSpaceOnUse\" x1=\"1\" y1=\"1\" x2=\"1\" y2=\"43\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(215, 100, 48); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_2&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"bold\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(215,100,48); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#d76430\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(176 21)\" style=\"\">\n\t<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_4\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_4&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(176 21)\" style=\"\">\n\t<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_6\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_6&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
textbutton148164.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 352 42\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(176 21)\" style=\"\">\n	<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_8\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_8&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(176 21)\">\n		<text font-family=\"\'Calibri\'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 49px; top: 124px; width: 352px; height: 42px; z-index: 11; cursor: pointer; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148164",
	bInsAnc:	1,
	cwObj:		{
		"name":	"Button 2",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page143165.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,32800,0,[49,124.00000000000004,352,42]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":352,"height":42},"imgDataNormal":"images/desktop_shape148164.png","imgDataOver":"images/desktop_shape148164_over.png","imgDataDown":"images/desktop_shape148164.png","imgDataDisabled":"images/desktop_shape148164_disabled.png","svgDataNormal":"<g transform=\"translate(176 21)\" style=\"\">\n\t<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_8\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_8&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<linearGradient id=\"SVGID_148159_9\" gradientUnits=\"userSpaceOnUse\" x1=\"0\" y1=\"0\" x2=\"0\" y2=\"42\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<g transform=\"translate(176 21)\" style=\"\">\n\t<linearGradient id=\"SVGID_148159_9\" gradientUnits=\"userSpaceOnUse\" x1=\"1\" y1=\"1\" x2=\"1\" y2=\"43\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(215, 100, 48); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_9&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"bold\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(215,100,48); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#d76430\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(176 21)\" style=\"\">\n\t<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_11\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_11&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(176 21)\" style=\"\">\n\t<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_13\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"350\" height=\"40\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 20 0 L 330 0 A 20 20 0 0 1 350 20 L 350 20 A 20 20 0 0 1 330 40 L 20 40 A 20 20 0 0 1 0 20 L 0 20 A 20 20 0 0 1 20 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_13&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-175, -20) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(176 21)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"18.6666662\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"-168\" y=\"5.88\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og148172.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148172",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape148173.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 120 120\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(60 60)\" style=\"\">\n	<path d=\"M 0 60 A 60 60 0 1 1 120 60 A 60 60 0 1 1 0 60 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(254, 182, 8); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-60, -60) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(60 60)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 165px; top: 234px; width: 120px; height: 120px; z-index: 12; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148173",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Ellipse"
	},
	objData:	{"a":[0,32,0,[165,234,120,120]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":165,"y":234,"width":120,"height":120},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148173.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape148174.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 100 100\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(50 50)\" style=\"\">\n	<path d=\"M 0 50 A 50 50 0 1 1 100 50 A 50 50 0 1 1 0 50 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-50, -49.99999999999999) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(50 50)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 175px; top: 244px; width: 100px; height: 100px; z-index: 13; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148174",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Ellipse"
	},
	objData:	{"a":[0,32,0,[175,244,100,100]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":175,"y":244,"width":100,"height":100},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148174.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148175.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 104px; min-height: 56px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 104px; min-height: 56px;\"><p style=\"text-align: center;\"><span><strong><span style=\"font-size:26pt; color: rgb(102, 102, 102); font-family: Arial, sans-serif;\">...</span></strong></span></p></div></div>",
	cssText:	"left: 173px; top: 269px; visibility: hidden; position: absolute; width: 104px; height: 56px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj148175",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 2",
		"arChld":
	[
		{type:6,on:5,delay:0,name:'OnShowChange',actItem:function(){ text148175.changeContents( "" +  AICC_Score.getValueForDisplay() + "%" ); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:5,delay:0,name:'OnShowChange',actItem:function(){ if(trivPageTracking.getRangeStatus(148159,true) == "inprogress"&&VarAICC_Score_BasedOn_MyScore.equals('0'))text148175.changeContents( "0%" ); else if(typeof pF == 'function') pF();
    if(typeof pF == 'function') pF(); }},
		{type:6,on:5,delay:0,name:'OnShowChange',actItem:function(){ if(trivPageTracking.getRangeStatus(148159,true) == "inprogress"&&VarAICC_Score_BasedOn_MyScore.equals('0'))text148175.changeContents( "0%" ); else if(typeof pF == 'function') pF();
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[32,32,[35,0,4,0,400,0],[173,269,104,56]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":173,"y":269,"width":104,"height":56},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148177.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 104px; min-height: 34px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 104px; min-height: 34px;\"><p style=\"text-align:center\"><span><strong><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:14pt;\">Voortgang</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 170px; top: 199px; width: 104px; height: 34px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj148177",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[170,199,104,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":170,"y":199,"width":104,"height":34},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og148178.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148178",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape148179.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 496 230\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(248 115)\" style=\"\">\n	<path d=\"M 9.01 0 L 486.99 0 A 9.01 9.01 0 0 1 496 9.01 L 496 220.99 A 9.01 9.01 0 0 1 486.99 230 L 9.01 230 A 9.01 9.01 0 0 1 0 220.99 L 0 9.01 A 9.01 9.01 0 0 1 9.01 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-248, -115) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(248 115)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 473px; top: 69px; width: 496px; height: 230px; z-index: 16; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148179",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rounded Rectangle"
	},
	objData:	{"a":[0,32,0,[473,69.00000000000006,496,230]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":473,"y":69,"width":496,"height":230},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148179.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148180.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 455px; min-height: 216px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 455px; min-height: 216px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:14pt;\">Waar gaat dit hoofdstuk&nbsp;over?</span></strong></span></p><p style=\"text-align:left\"><span style=\"font-family:Arial, sans-serif\">​</span></p><p><span style=\"font-family: calibri; font-size:12pt;\">Water en strooisel zijn cruciale onderdelen voor het welzijn en de gezondheid van vleeskuikens. Een goede waterkwaliteit is voor jonge vleeskuikens namelijk van groot belang omdat hun darmflora nog in opbouw is. En ook de keuze voor het strooisel dat past bij de condities en vloeren in je stal is erg belangrijk. Analyseer deze twee onderdelen dan ook zorgvuldig.&nbsp;</span></p><p><span><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">&nbsp;</span></span></p><p><span>&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 496px; top: 85px; width: 455px; height: 216px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj148180",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[496,85,455,216]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":496,"y":85,"width":455,"height":216},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og148181.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148181",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
image148182.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148182Img\" src=\"images/correct.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 26px; height: 26px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 60px; top: 76px; width: 26px; height: 26px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj148182",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-1"
	},
	objData:	{"a":[0,256,0,[60,76,26,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":60,"y":76,"width":26,"height":26}}
};
image148183.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148183Img\" src=\"images/correct.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 26px; height: 26px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 60px; top: 132px; width: 26px; height: 26px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj148183",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-2"
	},
	objData:	{"a":[0,256,0,[60,132,26,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":60,"y":132,"width":26,"height":26}}
};
og148187.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148187",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text148188.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 176px; min-height: 32px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 176px; min-height: 32px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:14pt;\">Colofon</span></strong></span></p></div></div>",
	cssText:	"left: 1255px; top: 300px; visibility: hidden; position: absolute; width: 176px; height: 32px; z-index: 20; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj148188",
	bInsAnc:	1,
	cwObj:		{
		"name":	"Text Block 1",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ if( text148188.eatOnUp==true ){
        text148188.eatOnUp=false;
        return;
    }
    og148204.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[36,32,[26,0,6,0,3000,0,776,300,7,0],[1255,300,176,32]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":776,"y":300,"width":176,"height":32},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
textbutton148190.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 37 37\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(18.5 18.5)\" style=\"\">\n	<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_15\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/colofon.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_15&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(18.5 18.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"left: 1066px; top: 294px; visibility: hidden; position: absolute; width: 37px; height: 37px; z-index: 21; cursor: pointer; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148190",
	bInsAnc:	1,
	cwObj:		{
		"name":	"Button leren",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og148204.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[36,33056,[26,0,6,0,3000,0,726,294,7,0],[1066,294,37,37]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":726,"y":294,"width":37,"height":37},"imgDataNormal":"images/desktop_shape148190.png","imgDataOver":"images/desktop_shape148190_over.png","imgDataDown":"images/desktop_shape148190_over.png","imgDataDisabled":"images/desktop_shape148190_disabled.png","svgDataNormal":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_15\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/colofon.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_15&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_17\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/colofon-h.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_17&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_19\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/colofon-h.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_19&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_21\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/colofon.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_21&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og148192.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148192",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text148193.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 156px; min-height: 32px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 156px; min-height: 32px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:14pt;\">Wat ga je&nbsp;leren?&nbsp;</span></strong></span></p></div></div>",
	cssText:	"left: 1235px; top: 297px; visibility: hidden; position: absolute; width: 156px; height: 32px; z-index: 22; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj148193",
	bInsAnc:	1,
	cwObj:		{
		"name":	"Text Block 1",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ if( text148193.eatOnUp==true ){
        text148193.eatOnUp=false;
        return;
    }
    og148197.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[36,32,[26,0,7,0,500,0,539,297,7,0],[1235,297,156,32]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":539,"y":297,"width":156,"height":32},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
textbutton148195.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 37 37\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(18.5 18.5)\" style=\"\">\n	<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_23\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/leren.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_23&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(18.5 18.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"left: 1066px; top: 291px; visibility: hidden; position: absolute; width: 37px; height: 37px; z-index: 23; cursor: pointer; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148195",
	bInsAnc:	1,
	cwObj:		{
		"name":	"Button leren",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og148197.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[36,34080,[26,0,7,0,500,0,489,291,7,0],[1066,291,37,37]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":489,"y":291,"width":37,"height":37},"imgDataNormal":"images/desktop_shape148195.png","imgDataOver":"images/desktop_shape148195_over.png","imgDataDown":"images/desktop_shape148195_over.png","imgDataDisabled":"images/desktop_shape148195_disabled.png","svgDataNormal":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_23\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/leren.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_23&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_25\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/leren-H.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_25&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_27\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/leren-H.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_27&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(18.5 18.5)\" style=\"\">\n\t<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_29\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"37\" height=\"37\" xlink:href=\"images/leren.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 37 0 L 37 37 L 0 37 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_29&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-18.5, -18.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(18.5 18.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"0\" y=\"5.04\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og148197.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148197",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
shape148198.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 978 534\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(489 267)\" style=\"\">\n	<path d=\"M 12.75 0 L 965.25 0 A 12.75 12.75 0 0 1 978 12.75 L 978 521.25 A 12.75 12.75 0 0 1 965.25 534 L 12.75 534 A 12.75 12.75 0 0 1 0 521.25 L 0 12.75 A 12.75 12.75 0 0 1 12.75 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-489, -267) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(489 267)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 15px; top: 60px; width: 978px; height: 534px; z-index: 24; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148198",
	bInsAnc:	0,
	cwObj:		{
		"name":	"lerenbg"
	},
	objData:	{"a":[0,0,0,[14.999999999999943,60.000000000000114,978,534]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":15,"y":60,"width":978,"height":534},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148198.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148199.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; min-height: 484px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 440px; min-height: 484px;\"><p style=\"font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">1.&nbsp;Water</span></strong></span></p><ul style=\"padding-left: 31px; -webkit-padding-start: 31px;\"><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family:calibri\">Kritisch te kijken naar het waterverbruik en drinkhouding van de kuikens.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">De voor- en nadelen van verschillende drinkwatersystemen.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Dat jonge kuikens extra gevoelig zijn voor de kwaliteit van het water.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Welke invloed waterdruk, temperatuur en verschillende soorten waterleidingen van invloed hebben op de waterkwaliteit.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Hoe biofilm ontstaat en wat je ertegen kunt doen.</span></li></ul><p style=\"color: rgb(0, 0, 0);\"><span>​</span></p><p style=\"color: rgb(0, 0, 0);\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">2.&nbsp;Strooisel</span></strong></span></p><ul style=\"padding-left: 33px; -webkit-padding-start: 33px;\"><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family:calibri\">Dat het type vloer van invloed is op de kwaliteit van het strooisel.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Over verschillende soorten strooisel en hun kenmerken.&nbsp;</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Hoe je de kwaliteit van strooisel dagelijks beoordeelt.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Hoe je omgaat met signalen van verminderde kwaliteit.</span></li></ul><p style=\"color: rgb(0, 0, 0);\"><span>​</span></p><ul style=\"padding-left: 33px; -webkit-padding-start: 33px;\"></ul><p style=\"font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">​</span></p><ul style=\"padding-left: 31px; -webkit-padding-start: 31px;\"></ul><p style=\"font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:11pt;\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 125px; width: 440px; height: 484px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj148199",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,0,0,[50,125,440,484]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":440,"height":484},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148200.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 452px; min-height: 385px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 452px; min-height: 385px;\"></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 528px; top: 125px; width: 452px; height: 385px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj148200",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,0,0,[528,125,452,385]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":528,"y":125,"width":452,"height":385},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image148542.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148542Img\" src=\"images/32.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 440px; height: 293px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 127px; width: 440px; height: 293px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj148542",
	bInsAnc:	0,
	cwObj:		{
		"name":	"32"
	},
	objData:	{"a":[0,256,0,[524,127,440,293]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":127,"width":440,"height":293}}
};
text148541.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; min-height: 71px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 440px; min-height: 71px;\"><p style=\"text-align:left\"><span><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">De huidige nippels zijn zo goed dat lekbakjes niet meer nodig zijn. Het gebruik van lekbakjes is goed voor het strooisel en de kwaliteit van de voetzolen, maar ze raken wel snel bevuild.&nbsp;</span></em></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 525px; top: 422px; width: 440px; height: 71px; z-index: 28;",
	cssClasses:	"",
	htmlId:		"tobj148541",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschrift"
	},
	objData:	{"a":[0,0,0,[525,422,440,71]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":525,"y":422,"width":440,"height":71},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148201.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 607px; min-height: 26px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 607px; min-height: 26px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:16pt;\">Wat ga je leren?</span></strong></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 80px; width: 607px; height: 26px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj148201",
	bInsAnc:	0,
	cwObj:		{
		"name":	"titel"
	},
	objData:	{"a":[0,0,0,[50,80,607,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":80,"width":607,"height":26},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148202.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148202Img\" src=\"images/close-hover.png\" style=\"position: absolute; left: 0px; top: 0px; width: 22px; height: 22px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 960px; top: 70px; width: 22px; height: 22px; z-index: 30; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj148202",
	bInsAnc:	1,
	cwObj:		{
		"name":	"close-hover",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og148197.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,256,0,[960,70,22,22]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":960,"y":70,"width":22,"height":22},"res":"images/close-hover.png","resClick":"images/close-hover.png","resOver":"images/close149175.png"}
};
og148204.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148204",
	bInsAnc:	undefined,
	objData:	{"a":[0,64,0,[]],"bReadLast":false}
};
shape148205.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 978 534\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(489 267)\" style=\"\">\n	<path d=\"M 12.75 0 L 965.25 0 A 12.75 12.75 0 0 1 978 12.75 L 978 521.25 A 12.75 12.75 0 0 1 965.25 534 L 12.75 534 A 12.75 12.75 0 0 1 0 521.25 L 0 12.75 A 12.75 12.75 0 0 1 12.75 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-489, -267) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(489 267)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 15px; top: 60px; width: 978px; height: 534px; z-index: 33; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148205",
	bInsAnc:	0,
	cwObj:		{
		"name":	"lerenbg"
	},
	objData:	{"a":[0,0,0,[14.999999999999943,60.000000000000114,978,534]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":15,"y":60,"width":978,"height":534},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148198.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148206.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 607px; min-height: 52px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 607px; min-height: 52px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:16pt;\">Colofon</span></strong></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 80px; width: 607px; height: 52px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj148206",
	bInsAnc:	0,
	cwObj:		{
		"name":	"titel"
	},
	objData:	{"a":[0,0,0,[50,80,607,52]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":80,"width":607,"height":52},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148207.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 290px; height: 417px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 282px; height: 409px;\"><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><strong><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">© Roodbont Publishers B.V., 2018</span></strong></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\" font-size:10pt; font-family:\'\'Calibri\',sans serif\'; color:#010101;\">&nbsp;</span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><em><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">Niets uit deze uitgave mag worden verveelvoudigd en/of openbaar worden gemaakt door middel van druk, fotokopie of op welke andere wijze dan ook, zonder voorafgaande schriftelijke toestemming van de uitgever. </span></em></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span>​</span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><em><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">Uitgever heeft de inhoud van deze module met grote zorgvuldigheid en naar beste weten samengesteld. Uitgever aanvaardt evenwel geen aansprakelijkheid door schade, van welke aard dan ook, die het gevolg is van handelingen en/of beslissingen die gebaseerd zijn op bedoelde informatie. </span></em></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span>​</span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><em><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">Uitgever heeft geprobeerd de rechthebbenden van het beeldmateriaal te achterhalen. Wanneer een bron onvermeld is gebleven of onjuist is, kunnen rechthebbenden contact opnemen met de uitgever. </span></em></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 686px; top: 125px; width: 290px; height: 417px; z-index: 35;",
	cssClasses:	"",
	htmlId:		"tobj148207",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 5"
	},
	objData:	{"a":[0,0,0,[686,125,290,417]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":686,"y":125,"width":290,"height":417},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text148208.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 292px; min-height: 484px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 292px; min-height: 484px;\"><p><span><strong><span style=\"font-family: calibri; font-size:10pt;\">Uitgever:</span></strong></span></p><p><span style=\"font-family: calibri; font-size:10pt;\">Roodbont Publishers B.V.​</span></p><p><span style=\"font-family: calibri; font-size:10pt;\">​</span></p><p><span style=\"font-family: calibri; font-size:10pt;\"><strong>Auteurs:</strong> </span></p><p><span style=\"font-family: calibri; font-size:10pt;\">Maarten de Gussem, Edward Mailyan, Koos van Middelkoop, Kristof van Mullem, Ellen van \'t Veer, Ton van Schie en&nbsp;Reinout Renard</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">&nbsp;</span><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">&nbsp;</span></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">Redactie</span></strong><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">: </span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Ton van Schie </span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span><strong><span style=\"color: rgb(0, 0, 0); font-family: Calibri, sans-serif; font-size:10pt;\">Ontwerp:</span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Educontinu</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">Illustraties:</span></strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\"> </span></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Marinette Hoogendoorn, Dick Rietveld </span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span><strong><span style=\"color: rgb(0, 0, 0); font-family: Calibri, sans-serif; font-size:10pt;\">Animaties:</span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Trudy Michels</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">Fotografie:</span></strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\"> </span></span></p><p><span style=\"font-family: Calibri, sans-serif; font-size:10pt;\">Aardvark Brewing, Agrifirm, Marcel Berendsen, GD, Impex, Berry Lott, Edward Mailyan, Koos van Middelkoop, PTC+ (Helmich van Rees), Henk Rodenboog, Roxell, Wouter Steenhuisen, Joost Straathof, Verhoeven fourage, Vetworks, Andries de Vries, Wageningen UR Livestock Research, www.equisupplies.co.uk</span></p><p><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 125px; width: 292px; height: 484px; z-index: 36;",
	cssClasses:	"",
	htmlId:		"tobj148208",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[50,125,292,484]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":292,"height":484},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148209.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 302px; min-height: 144px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 302px; min-height: 144px;\"><p style=\"line-height: normal; text-align: left; margin-bottom: 0px; margin-top: 0px;\"><span><strong><span style=\"font-family: Calibri, sans-serif; font-size:10pt;\">Met dank aan:</span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt;\">Henk Rodenboog, Mark Roozen, Monique Bestman, Wouter Steenhuisen, Merel&nbsp;van der Werf, Laura Star, Helmich van Rees,&nbsp;Arthur Slaats, Ruud van Wee,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Joost Koster,&nbsp;Jeroen van der Heijden, Henry Arts,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Gerd de&nbsp;Lange, Mari van Gruijthuijsen,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Richard&nbsp;Wentzel,&nbsp;Andries de Vries, Jacco Wagelaar,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Jan Dirk van&nbsp;der Klis, Karin Jonkers en Dirk Nijhof</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 366px; top: 125px; width: 302px; height: 144px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj148209",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 5"
	},
	objData:	{"a":[0,0,0,[366,125,302,144]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":366,"y":125,"width":302,"height":144},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image148210.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148210Img\" src=\"images/logo-vetworks-colfon.gif\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 134px; height: 41px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 420px; width: 134px; height: 41px; z-index: 38;",
	cssClasses:	"",
	htmlId:		"tobj148210",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-vetworks-colfon"
	},
	objData:	{"a":[0,256,0,[524,420,134,41]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":420,"width":134,"height":41}}
};
image148211.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148211Img\" src=\"images/logo-RB-colofon.gif\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 119px; height: 36px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 534px; top: 274px; width: 119px; height: 36px; z-index: 39;",
	cssClasses:	"",
	htmlId:		"tobj148211",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-RB-colofon"
	},
	objData:	{"a":[0,256,0,[534,274,119,36]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":534,"y":274,"width":119,"height":36}}
};
text148212.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 292px; min-height: 127px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 292px; min-height: 127px;\"><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">Roodbont Publishers B.V.</span></strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">Postbus 4103 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">7200 BC Zutphen </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">Nederland </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">T (0575) 54 56 88 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">E </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148216()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">info@roodbont.com </span></a></span></p><p style=\"margin-left: 0px; text-indent: 0px; margin-top: 0px; margin-bottom: 0px; line-height: normal;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">I </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148217()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">www.roodbont.com</span></a><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 366px; top: 278px; width: 292px; height: 127px; z-index: 40;",
	cssClasses:	"",
	htmlId:		"tobj148212",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 4"
	},
	objData:	{"a":[0,0,0,[366,278,292,127]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":366,"y":278,"width":292,"height":127},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148213.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 292px; min-height: 131px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 292px; min-height: 131px;\"><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">Vetworks BVBA</span></strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">Knokstraat 38 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">B-9880 Poeke </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">België </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">T +32 (0)473 99 93 79 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">E </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148218()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">info@vetworks.eu </span></a></span></p><p style=\"margin-left: 0px; text-indent: 0px; margin-top: 0px; margin-bottom: 0px; line-height: normal;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">I </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148219()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">www.vetworks.eu</span></a><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 366px; top: 420px; width: 292px; height: 131px; z-index: 41;",
	cssClasses:	"",
	htmlId:		"tobj148213",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 4"
	},
	objData:	{"a":[0,0,0,[366,420,292,131]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":366,"y":420,"width":292,"height":131},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148214.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148214Img\" src=\"images/close-hover.png\" style=\"position: absolute; left: 0px; top: 0px; width: 22px; height: 22px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 960px; top: 70px; width: 22px; height: 22px; z-index: 42; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj148214",
	bInsAnc:	1,
	cwObj:		{
		"name":	"close-hover",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og148204.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,256,0,[960,70,22,22]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":960,"y":70,"width":22,"height":22},"res":"images/close-hover.png","resClick":"images/close-hover.png","resOver":"images/close149175.png"}
};
rcdObj.rcdData.att_Desktop = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	1
};
rcdObj.pgWidth_Desktop = pgWidth_desktop;
rcdObj.preload_Desktop = ["images/logo-vetworks-colfon.gif","images/logo-RB-colofon.gif","images/32.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-trans.png","images/correct.png","images/colofon.png","images/colofon-h.png","images/leren-H.png","images/close-hover.png","images/close149175.png","images/kaft-water-en-strooisel.jpg","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png"];
rcdObj.pgStyle_Desktop = 'position: absolute; left: 0px; top: 0px; width: 1009px; height: 609px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_Desktop = ["#eeeeee","",0,0,1];
