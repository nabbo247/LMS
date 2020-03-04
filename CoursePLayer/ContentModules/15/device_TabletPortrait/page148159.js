if (window.VarCurrentView) VarCurrentView.set('TabletPortrait');
function init_TabletPortrait() {
	if ( rcdObj.view != 'TabletPortrait' ) return;
	if (!isOPAPub() || isLOPopup()) window.init_page();
	preload(rcdObj['preload_'+rcdObj.view]);
}
function defineFuncs_TabletPortrait() {
	if ( rcdObj.view != 'TabletPortrait' ) return;
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
}
og148932.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148932",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
og28117.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og28117",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape146877.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 473\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 236.5)\" style=\"\">\n	<path d=\"M 0 0 L 784 0 L 784 472 L 0 472 L 0 0 Z\" style=\"stroke: rgb(219, 102, 39); stroke-width: 1; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392, -236) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 236.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.816326210204082\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: -0.5px; top: -0.5px; width: 785px; height: 473px; z-index: 1; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj146877",
	bInsAnc:	0,
	cwObj:		{
		"name":	"kaderlijn"
	},
	objData:	{"a":[0,32,0,[-0.5000000000000568,-0.49999999999991473,785,473]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 785 0 L 785 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 9.59233e-14px; width: 785px; height: 35px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,9.592326932761353e-14,785,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137498.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 783 26\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(391.5 13)\" style=\"\">\n	<path d=\"M 0 0 L 783 0 L 783 26 L 0 26 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-391.5, -13) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(391.5 13)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 1px; top: 45px; width: 783px; height: 26px; z-index: 3; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137498",
	bInsAnc:	0,
	cwObj:		{
		"name":	"subheaderbackground"
	},
	objData:	{"a":[0,160,0,[1,45.0000000000001,783,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
button146730.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146730Img\" src=\"images/btn-close143187.png\" style=\"position: absolute; left: 0px; top: 0px; width: 16px; height: 16px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 759px; top: 14px; width: 16px; height: 16px; z-index: 4; cursor: pointer;",
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
	objData:	{"a":[4,288,0,[759,14,16,16]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":975,"y":14,"width":20,"height":20},"res":"images/btn-close143187.png","resClick":"images/btn-close143187.png","resOver":"images/btn-close-hover143188.png"}
};
image147010.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147010Img\" src=\"images/logo-roodbont.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 105px; height: 16px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 663px; top: 52px; width: 105px; height: 16px; z-index: 5;",
	cssClasses:	"",
	htmlId:		"tobj147010",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-roodbont"
	},
	objData:	{"a":[0,256,0,[663,52,105,16]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":852,"y":52,"width":135,"height":21}}
};
text354.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 669px; min-height: 31px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 669px; min-height: 31px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span><strong><span style=\"font-size:22pt; color: rgb(255, 255, 255); font-family: calibri;\">Vleeskuikensignalen -&nbsp;</span></strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:22pt;\">Water en strooisel</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 5px; width: 669px; height: 31px; z-index: 6;",
	cssClasses:	"",
	htmlId:		"tobj354",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Title module"
	},
	objData:	{"a":[0,32,0,[39,5,669,31]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":5,"width":860,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146550.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 700px; min-height: 26px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 700px; min-height: 26px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span style=\"font-size:18pt; color: rgb(102, 102, 102); font-family: calibri;\">Title of chapter</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 47px; width: 700px; height: 26px; z-index: 7;",
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
	objData:	{"a":[0,32,0,[39,47,700,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":47,"width":900,"height":34},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og148948.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148948",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape148949.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148949Img\" src=\"images/shape9277.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 785px; height: 1000px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; z-index: 31;",
	cssClasses:	"",
	htmlId:		"tobj148949",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,16480,0,[0,0,785,1000]],"rcdOvr":{"res":2},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1047,"y":0,"width":1009,"height":608}}
};
image148950.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148950Img\" src=\"images/rotate-mobile.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 397px; height: 397px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 194px; top: 100px; width: 397px; height: 397px; z-index: 32;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[194,100,397,397]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
image148160.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148160Img\" src=\"images/kaft-water-en-strooisel.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 784px; height: 441px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 1px; top: 42px; width: 784px; height: 441px; z-index: 8;",
	cssClasses:	"",
	htmlId:		"tobj148160",
	bInsAnc:	0,
	cwObj:		{
		"name":	"kaft-water-en-strooisel"
	},
	objData:	{"a":[0,32,0,[1,42,784,441]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":42,"width":1008,"height":567}}
};
shape148161.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 386 59\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(193 29.5)\" style=\"\">\n	<path d=\"M 6.11 0 L 379.89 0 A 6.11 6.11 0 0 1 386 6.11 L 386 52.89 A 6.11 6.11 0 0 1 379.89 59 L 6.11 59 A 6.11 6.11 0 0 1 0 52.89 L 0 6.11 A 6.11 6.11 0 0 1 6.11 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-193, -29.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(193 29.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 368px; top: 278px; width: 386px; height: 59px; z-index: 9; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148161",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rounded Rectangle"
	},
	objData:	{"a":[0,32,0,[368,278.00000000000006,386,59]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":473,"y":278,"width":496,"height":76},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148161.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
textbutton148162.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 274 33\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(137 16.5)\" style=\"\">\n	<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_43\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_43&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(137 16.5)\">\n		<text font-family=\"\'Calibri\'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 38px; top: 68px; width: 274px; height: 33px; z-index: 10; cursor: pointer; overflow: visible; pointer-events: none;",
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
	objData:	{"a":[4,32800,0,[38,68.00000000000003,274,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":69,"width":352,"height":42},"imgDataNormal":"images/desktop_shape148162.png","imgDataOver":"images/desktop_shape148162_over.png","imgDataDown":"images/desktop_shape148162.png","imgDataDisabled":"images/desktop_shape148162_disabled.png","svgDataNormal":"<g transform=\"translate(137 16.5)\" style=\"\">\n\t<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_43\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_43&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<linearGradient id=\"SVGID_148159_44\" gradientUnits=\"userSpaceOnUse\" x1=\"0\" y1=\"0\" x2=\"0\" y2=\"33\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<g transform=\"translate(137 16.5)\" style=\"\">\n\t<linearGradient id=\"SVGID_148159_44\" gradientUnits=\"userSpaceOnUse\" x1=\"1\" y1=\"1\" x2=\"1\" y2=\"34\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(215, 100, 48); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_44&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"bold\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(215,100,48); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#d76430\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(137 16.5)\" style=\"\">\n\t<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_46\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_46&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(137 16.5)\" style=\"\">\n\t<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_48\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_48&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Water</tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
textbutton148164.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 274 33\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(137 16.5)\" style=\"\">\n	<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_50\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_50&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(137 16.5)\">\n		<text font-family=\"\'Calibri\'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 38px; top: 124px; width: 274px; height: 33px; z-index: 11; cursor: pointer; overflow: visible; pointer-events: none;",
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
	objData:	{"a":[4,32800,0,[38,124.00000000000003,274,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":352,"height":42},"imgDataNormal":"images/desktop_shape148164.png","imgDataOver":"images/desktop_shape148164_over.png","imgDataDown":"images/desktop_shape148164.png","imgDataDisabled":"images/desktop_shape148164_disabled.png","svgDataNormal":"<g transform=\"translate(137 16.5)\" style=\"\">\n\t<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_50\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_50&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<linearGradient id=\"SVGID_148159_51\" gradientUnits=\"userSpaceOnUse\" x1=\"0\" y1=\"0\" x2=\"0\" y2=\"33\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<g transform=\"translate(137 16.5)\" style=\"\">\n\t<linearGradient id=\"SVGID_148159_51\" gradientUnits=\"userSpaceOnUse\" x1=\"1\" y1=\"1\" x2=\"1\" y2=\"34\">\n<stop offset=\"0%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"10%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"35%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n<stop offset=\"100%\" style=\"stop-color:rgb(255,255,255);stop-opacity: 1\"></stop>\n</linearGradient>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(215, 100, 48); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_51&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"bold\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(215,100,48); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#d76430\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(137 16.5)\" style=\"\">\n\t<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_53\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_53&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(137 16.5)\" style=\"\">\n\t<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0 Z\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_55\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"272\" height=\"31\" xlink:href=\"images/btn-trans.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 15.5 0 L 256.5 0 A 15.5 15.5 0 0 1 272 15.5 L 272 15.5 A 15.5 15.5 0 0 1 256.5 31 L 15.5 31 A 15.5 15.5 0 0 1 0 15.5 L 0 15.5 A 15.5 15.5 0 0 1 15.5 0\" style=\"stroke: rgb(254, 182, 8); stroke-width: 2; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_55&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-136, -15.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(137 16.5)\">\n\t\t<text font-family=\"'Calibri'\" font-size=\"15.043136878823532\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"-130.13\" y=\"4.74\" fill=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Strooisel</tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og148172.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148172",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape148173.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 93 93\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(46.5 46.5)\" style=\"\">\n	<path d=\"M 0 46.5 A 46.5 46.5 0 1 1 93 46.5 A 46.5 46.5 0 1 1 0 46.5 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(254, 182, 8); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-46.5, -46.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(46.5 46.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 128px; top: 234px; width: 93px; height: 93px; z-index: 12; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148173",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Ellipse"
	},
	objData:	{"a":[0,32,0,[127.99999999999999,234,93,93]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":165,"y":234,"width":120,"height":120},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148173.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape148174.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 78 78\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(39 39)\" style=\"\">\n	<path d=\"M 0 39 A 39 39 0 1 1 78 39 A 39 39 0 1 1 0 39 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-39, -38.99999999999999) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(39 39)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 136px; top: 244px; width: 78px; height: 78px; z-index: 13; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148174",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Ellipse"
	},
	objData:	{"a":[0,32,0,[136,244,78,78]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":175,"y":244,"width":100,"height":100},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148174.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148175.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 81px; min-height: 44px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 81px; min-height: 44px;\"><p style=\"text-align: center;\"><span><strong><span style=\"font-size:26pt; color: rgb(102, 102, 102); font-family: Arial, sans-serif;\">...</span></strong></span></p></div></div>",
	cssText:	"left: 135px; top: 269px; visibility: hidden; position: absolute; width: 81px; height: 44px; z-index: 14;",
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
	objData:	{"a":[32,32,[35,0,4,0,400,0],[135,269,81,44]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":173,"y":269,"width":104,"height":56},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148177.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 81px; min-height: 26px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 81px; min-height: 26px;\"><p style=\"text-align:center\"><span><strong><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:14pt;\">Voortgang</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 132px; top: 199px; width: 81px; height: 26px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj148177",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[132,199,81,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":170,"y":199,"width":104,"height":34},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og148178.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148178",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape148179.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 386 179\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(193 89.5)\" style=\"\">\n	<path d=\"M 7.01 0 L 378.99 0 A 7.01 7.01 0 0 1 386 7.01 L 386 171.99 A 7.01 7.01 0 0 1 378.99 179 L 7.01 179 A 7.01 7.01 0 0 1 0 171.99 L 0 7.01 A 7.01 7.01 0 0 1 7.01 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-193, -89.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(193 89.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 368px; top: 69px; width: 386px; height: 179px; z-index: 16; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148179",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rounded Rectangle"
	},
	objData:	{"a":[0,32,0,[368,69.00000000000004,386,179]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":473,"y":69,"width":496,"height":230},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148179.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148180.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 354px; min-height: 168px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 354px; min-height: 168px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:14pt;\">Waar gaat dit hoofdstuk&nbsp;over?</span></strong></span></p><p style=\"text-align:left\"><span style=\"font-family:Arial, sans-serif\">​</span></p><p><span style=\"font-family: calibri; font-size:12pt;\">Water en strooisel zijn cruciale onderdelen voor het welzijn en de gezondheid van vleeskuikens. Een goede waterkwaliteit is voor jonge vleeskuikens namelijk van groot belang omdat hun darmflora nog in opbouw is. En ook de keuze voor het strooisel dat past bij de condities en vloeren in je stal is erg belangrijk. Analyseer deze twee onderdelen dan ook zorgvuldig.&nbsp;</span></p><p><span><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">&nbsp;</span></span></p><p><span>&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 386px; top: 85px; width: 354px; height: 168px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj148180",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[386,85,354,168]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":496,"y":85,"width":455,"height":216},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og148181.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148181",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
image148182.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148182Img\" src=\"images/correct.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 47px; top: 76px; width: 20px; height: 20px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj148182",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-1"
	},
	objData:	{"a":[0,256,0,[47,76,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":60,"y":76,"width":26,"height":26}}
};
image148183.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148183Img\" src=\"images/correct.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 47px; top: 132px; width: 20px; height: 20px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj148183",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-2"
	},
	objData:	{"a":[0,256,0,[47,132,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":60,"y":132,"width":26,"height":26}}
};
og148187.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148187",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text148188.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 137px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 137px; min-height: 25px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:14pt;\">Colofon</span></strong></span></p></div></div>",
	cssText:	"left: 981px; top: 300px; visibility: hidden; position: absolute; width: 137px; height: 25px; z-index: 20; cursor: pointer;",
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
	objData:	{"a":[36,32,[26,0,6,0,3000,0,604,300,7,0],[981,300,137,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":776,"y":300,"width":176,"height":32},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
textbutton148190.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 29 29\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(14.5 14.5)\" style=\"\">\n	<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_57\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/colofon.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_57&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(14.5 14.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"left: 834px; top: 294px; visibility: hidden; position: absolute; width: 29px; height: 29px; z-index: 21; cursor: pointer; overflow: visible; pointer-events: none;",
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
	objData:	{"a":[36,33056,[26,0,6,0,3000,0,565,294,7,0],[834,294,29,29]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":726,"y":294,"width":37,"height":37},"imgDataNormal":"images/desktop_shape148190.png","imgDataOver":"images/desktop_shape148190_over.png","imgDataDown":"images/desktop_shape148190_over.png","imgDataDisabled":"images/desktop_shape148190_disabled.png","svgDataNormal":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_57\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/colofon.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_57&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_59\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/colofon-h.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_59&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_61\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/colofon-h.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_61&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_63\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/colofon.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_63&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og148192.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148192",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text148193.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 121px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 121px; min-height: 25px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:14pt;\">Wat ga je&nbsp;leren?&nbsp;</span></strong></span></p></div></div>",
	cssText:	"left: 965px; top: 297px; visibility: hidden; position: absolute; width: 121px; height: 25px; z-index: 22; cursor: pointer;",
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
	objData:	{"a":[36,32,[26,0,7,0,500,0,419,297,7,0],[965,297,121,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":539,"y":297,"width":156,"height":32},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
textbutton148195.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 29 29\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\" aria-hidden=\"true\"><g transform=\"translate(14.5 14.5)\" style=\"\">\n	<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n	<pattern id=\"SVGID_148159_65\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/leren.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_65&quot;); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(14.5 14.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"left: 834px; top: 291px; visibility: hidden; position: absolute; width: 29px; height: 29px; z-index: 23; cursor: pointer; overflow: visible; pointer-events: none;",
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
	objData:	{"a":[36,34080,[26,0,7,0,500,0,380,291,7,0],[834,291,29,29]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":489,"y":291,"width":37,"height":37},"imgDataNormal":"images/desktop_shape148195.png","imgDataOver":"images/desktop_shape148195_over.png","imgDataDown":"images/desktop_shape148195_over.png","imgDataDisabled":"images/desktop_shape148195_disabled.png","svgDataNormal":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_65\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/leren.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_65&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataOver":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_67\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/leren-H.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_67&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDown":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_69\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/leren-H.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_69&quot;); fill-rule: nonzero; opacity: 1; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 1;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","svgDataDisabled":"<g transform=\"translate(14.5 14.5)\" style=\"\">\n\t<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0 Z\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity: 0; fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n\t<pattern id=\"SVGID_148159_71\" x=\"0\" y=\"0\" width=\"1\" height=\"1\">\n<image x=\"0\" y=\"0\" width=\"29\" height=\"29\" xlink:href=\"images/leren.png\" preserveAspectRatio=\"none\"></image>\n</pattern>\n<path d=\"M 0 0 L 29 0 L 29 29 L 0 29 L 0 0\" style=\"stroke: rgb(9, 99, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: url(&quot;#SVGID_148159_71&quot;); fill-rule: nonzero; opacity: 0.6; pointer-events: auto;\" transform=\"translate(0 0) translate(-14.5, -14.5) \" stroke-linecap=\"round\"></path>\n</g>\n\t<g transform=\"translate(14.5 14.5)\">\n\t\t<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(255,255,255); fill-rule: nonzero; opacity: 0.6;\">\n\t\t\t<tspan x=\"0\" y=\"4.03\" fill=\"#FFFFFF\"></tspan>\n\t\t</text>\n\t</g>\n","btnState":"enabled","fallbackImg":"<img alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og148197.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148197",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
shape148198.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 761 415\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(380.5 207.5)\" style=\"\">\n	<path d=\"M 9.91 0 L 751.09 0 A 9.91 9.91 0 0 1 761 9.91 L 761 405.09 A 9.91 9.91 0 0 1 751.09 415 L 9.91 415 A 9.91 9.91 0 0 1 0 405.09 L 0 9.91 A 9.91 9.91 0 0 1 9.91 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-380.5, -207.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(380.5 207.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 12px; top: 60px; width: 761px; height: 415px; z-index: 24; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148198",
	bInsAnc:	0,
	cwObj:		{
		"name":	"lerenbg"
	},
	objData:	{"a":[0,0,0,[11.999999999999943,60.000000000000085,761,415]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":15,"y":60,"width":978,"height":534},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148198.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148199.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; min-height: 377px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 342px; min-height: 377px;\"><p style=\"font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">1.&nbsp;Water</span></strong></span></p><ul style=\"padding-left: 31px; -webkit-padding-start: 31px;\"><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family:calibri\">Kritisch te kijken naar het waterverbruik en drinkhouding van de kuikens.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">De voor- en nadelen van verschillende drinkwatersystemen.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Dat jonge kuikens extra gevoelig zijn voor de kwaliteit van het water.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Welke invloed waterdruk, temperatuur en verschillende soorten waterleidingen van invloed hebben op de waterkwaliteit.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Hoe biofilm ontstaat en wat je ertegen kunt doen.</span></li></ul><p style=\"color: rgb(0, 0, 0);\"><span>​</span></p><p style=\"color: rgb(0, 0, 0);\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">2.&nbsp;Strooisel</span></strong></span></p><ul style=\"padding-left: 33px; -webkit-padding-start: 33px;\"><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family:calibri\">Dat het type vloer van invloed is op de kwaliteit van het strooisel.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Over verschillende soorten strooisel en hun kenmerken.&nbsp;</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Hoe je de kwaliteit van strooisel dagelijks beoordeelt.</span></li><li style=\"font-size:11pt; font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">Hoe je omgaat met signalen van verminderde kwaliteit.</span></li></ul><p style=\"color: rgb(0, 0, 0);\"><span>​</span></p><ul style=\"padding-left: 33px; -webkit-padding-start: 33px;\"></ul><p style=\"font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:12pt;\">​</span></p><ul style=\"padding-left: 31px; -webkit-padding-start: 31px;\"></ul><p style=\"font-family: Arial, sans-serif; color: rgb(0, 0, 0);\"><span style=\"font-family: calibri; font-size:11pt;\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 125px; width: 342px; height: 377px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj148199",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,0,0,[39,125,342,377]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":440,"height":484},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148200.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 352px; min-height: 300px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 352px; min-height: 300px;\"></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 411px; top: 125px; width: 352px; height: 300px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj148200",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,0,0,[411,125,352,300]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":528,"y":125,"width":452,"height":385},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image148542.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148542Img\" src=\"images/32.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 342px; height: 228px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 127px; width: 342px; height: 228px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj148542",
	bInsAnc:	0,
	cwObj:		{
		"name":	"32"
	},
	objData:	{"a":[0,256,0,[408,127,342,228]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":127,"width":440,"height":293}}
};
text148541.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; min-height: 55px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 342px; min-height: 55px;\"><p style=\"text-align:left\"><span><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">De huidige nippels zijn zo goed dat lekbakjes niet meer nodig zijn. Het gebruik van lekbakjes is goed voor het strooisel en de kwaliteit van de voetzolen, maar ze raken wel snel bevuild.&nbsp;</span></em></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 422px; width: 342px; height: 55px; z-index: 28;",
	cssClasses:	"",
	htmlId:		"tobj148541",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschrift"
	},
	objData:	{"a":[0,0,0,[408,422,342,55]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":525,"y":422,"width":440,"height":71},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148201.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 472px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 472px; min-height: 20px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:16pt;\">Wat ga je leren?</span></strong></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 80px; width: 472px; height: 20px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj148201",
	bInsAnc:	0,
	cwObj:		{
		"name":	"titel"
	},
	objData:	{"a":[0,0,0,[39,80,472,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":80,"width":607,"height":26},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148202.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148202Img\" src=\"images/close-hover.png\" style=\"position: absolute; left: 0px; top: 0px; width: 17px; height: 17px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 747px; top: 70px; width: 17px; height: 17px; z-index: 30; cursor: pointer;",
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
	objData:	{"a":[4,256,0,[747,70,17,17]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":960,"y":70,"width":22,"height":22},"res":"images/close-hover.png","resClick":"images/close-hover.png","resOver":"images/close149175.png"}
};
og148204.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148204",
	bInsAnc:	undefined,
	objData:	{"a":[0,64,0,[]],"bReadLast":false}
};
shape148205.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 761 415\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(380.5 207.5)\" style=\"\">\n	<path d=\"M 9.91 0 L 751.09 0 A 9.91 9.91 0 0 1 761 9.91 L 761 405.09 A 9.91 9.91 0 0 1 751.09 415 L 9.91 415 A 9.91 9.91 0 0 1 0 405.09 L 0 9.91 A 9.91 9.91 0 0 1 9.91 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-380.5, -207.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(380.5 207.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 12px; top: 60px; width: 761px; height: 415px; z-index: 33; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148205",
	bInsAnc:	0,
	cwObj:		{
		"name":	"lerenbg"
	},
	objData:	{"a":[0,0,0,[11.999999999999943,60.000000000000085,761,415]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":15,"y":60,"width":978,"height":534},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148198.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text148206.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 472px; min-height: 40px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 472px; min-height: 40px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:16pt;\">Colofon</span></strong></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 80px; width: 472px; height: 40px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj148206",
	bInsAnc:	0,
	cwObj:		{
		"name":	"titel"
	},
	objData:	{"a":[0,0,0,[39,80,472,40]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":80,"width":607,"height":52},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148207.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 226px; height: 417px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 218px; height: 417px;\"><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><strong><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">© Roodbont Publishers B.V., 2018</span></strong></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\" font-size:10pt; font-family:\'\'Calibri\',sans serif\'; color:#010101;\">&nbsp;</span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><em><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">Niets uit deze uitgave mag worden verveelvoudigd en/of openbaar worden gemaakt door middel van druk, fotokopie of op welke andere wijze dan ook, zonder voorafgaande schriftelijke toestemming van de uitgever. </span></em></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span>​</span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><em><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">Uitgever heeft de inhoud van deze module met grote zorgvuldigheid en naar beste weten samengesteld. Uitgever aanvaardt evenwel geen aansprakelijkheid door schade, van welke aard dan ook, die het gevolg is van handelingen en/of beslissingen die gebaseerd zijn op bedoelde informatie. </span></em></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span>​</span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span><em><span style=\"color: rgb(1, 1, 1); font-family: Calibri, sans-serif; font-size:10pt;\">Uitgever heeft geprobeerd de rechthebbenden van het beeldmateriaal te achterhalen. Wanneer een bron onvermeld is gebleven of onjuist is, kunnen rechthebbenden contact opnemen met de uitgever. </span></em></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 534px; top: 125px; width: 226px; height: 425px; z-index: 35;",
	cssClasses:	"",
	htmlId:		"tobj148207",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 5"
	},
	objData:	{"a":[0,0,0,[534,125,226,417]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":686,"y":125,"width":290,"height":417},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text148208.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 227px; min-height: 377px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 227px; min-height: 377px;\"><p><span><strong><span style=\"font-family: calibri; font-size:10pt;\">Uitgever:</span></strong></span></p><p><span style=\"font-family: calibri; font-size:10pt;\">Roodbont Publishers B.V.​</span></p><p><span style=\"font-family: calibri; font-size:10pt;\">​</span></p><p><span style=\"font-family: calibri; font-size:10pt;\"><strong>Auteurs:</strong> </span></p><p><span style=\"font-family: calibri; font-size:10pt;\">Maarten de Gussem, Edward Mailyan, Koos van Middelkoop, Kristof van Mullem, Ellen van \'t Veer, Ton van Schie en&nbsp;Reinout Renard</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">&nbsp;</span><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">&nbsp;</span></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">Redactie</span></strong><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">: </span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Ton van Schie </span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span><strong><span style=\"color: rgb(0, 0, 0); font-family: Calibri, sans-serif; font-size:10pt;\">Ontwerp:</span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Educontinu</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">Illustraties:</span></strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\"> </span></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Marinette Hoogendoorn, Dick Rietveld </span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span><strong><span style=\"color: rgb(0, 0, 0); font-family: Calibri, sans-serif; font-size:10pt;\">Animaties:</span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">Trudy Michels</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt; color: rgb(0, 0, 0);\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\"><strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\">Fotografie:</span></strong><span style=\"font-size:10pt; font-family: Calibri, sans-serif; color: rgb(0, 0, 0);\"> </span></span></p><p><span style=\"font-family: Calibri, sans-serif; font-size:10pt;\">Aardvark Brewing, Agrifirm, Marcel Berendsen, GD, Impex, Berry Lott, Edward Mailyan, Koos van Middelkoop, PTC+ (Helmich van Rees), Henk Rodenboog, Roxell, Wouter Steenhuisen, Joost Straathof, Verhoeven fourage, Vetworks, Andries de Vries, Wageningen UR Livestock Research, www.equisupplies.co.uk</span></p><p><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:10pt;\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 125px; width: 227px; height: 377px; z-index: 36;",
	cssClasses:	"",
	htmlId:		"tobj148208",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[39,125,227,377]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":292,"height":484},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148209.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 235px; min-height: 112px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 235px; min-height: 112px;\"><p style=\"line-height: normal; text-align: left; margin-bottom: 0px; margin-top: 0px;\"><span><strong><span style=\"font-family: Calibri, sans-serif; font-size:10pt;\">Met dank aan:</span></strong></span></p><p style=\"line-height: normal; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: Calibri, sans-serif; font-size:10pt;\">Henk Rodenboog, Mark Roozen, Monique Bestman, Wouter Steenhuisen, Merel&nbsp;van der Werf, Laura Star, Helmich van Rees,&nbsp;Arthur Slaats, Ruud van Wee,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Joost Koster,&nbsp;Jeroen van der Heijden, Henry Arts,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Gerd de&nbsp;Lange, Mari van Gruijthuijsen,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Richard&nbsp;Wentzel,&nbsp;Andries de Vries, Jacco Wagelaar,</span></p><p><span style=\"font-family:Calibri, sans-serif\">Jan Dirk van&nbsp;der Klis, Karin Jonkers en Dirk Nijhof</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 285px; top: 125px; width: 235px; height: 112px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj148209",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 5"
	},
	objData:	{"a":[0,0,0,[285,125,235,112]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":366,"y":125,"width":302,"height":144},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image148210.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148210Img\" src=\"images/logo-vetworks-colfon.gif\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 104px; height: 32px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 420px; width: 104px; height: 32px; z-index: 38;",
	cssClasses:	"",
	htmlId:		"tobj148210",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-vetworks-colfon"
	},
	objData:	{"a":[0,256,0,[408,420,104,32]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":420,"width":134,"height":41}}
};
image148211.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148211Img\" src=\"images/logo-RB-colofon.gif\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 93px; height: 28px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 415px; top: 274px; width: 93px; height: 28px; z-index: 39;",
	cssClasses:	"",
	htmlId:		"tobj148211",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-RB-colofon"
	},
	objData:	{"a":[0,256,0,[415,274,93,28]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":534,"y":274,"width":119,"height":36}}
};
text148212.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 227px; min-height: 99px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 227px; min-height: 99px;\"><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">Roodbont Publishers B.V.</span></strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">Postbus 4103 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">7200 BC Zutphen </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">Nederland </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">T (0575) 54 56 88 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">E </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148216()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">info@roodbont.com </span></a></span></p><p style=\"margin-left: 0px; text-indent: 0px; margin-top: 0px; margin-bottom: 0px; line-height: normal;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">I </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148217()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">www.roodbont.com</span></a><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 285px; top: 278px; width: 227px; height: 99px; z-index: 40;",
	cssClasses:	"",
	htmlId:		"tobj148212",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 4"
	},
	objData:	{"a":[0,0,0,[285,278,227,99]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":366,"y":278,"width":292,"height":127},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text148213.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 227px; min-height: 102px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 227px; min-height: 102px;\"><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">Vetworks BVBA</span></strong><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">Knokstraat 38 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">B-9880 Poeke </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">België </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:10pt;\">T +32 (0)473 99 93 79 </span></p><p leglh=\"1.156\" style=\"margin-left: 0px; text-indent: 0px; line-height: normal; margin-top: 0px; margin-bottom: 0px;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">E </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148218()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">info@vetworks.eu </span></a></span></p><p style=\"margin-left: 0px; text-indent: 0px; margin-top: 0px; margin-bottom: 0px; line-height: normal;\" align=\"left\"><span style=\"font-family:calibri;\"><span style=\"font-size:10pt; color: rgb(0, 0, 0);\">I </span><a style=\"cursor: pointer;\" href=\"javascript:hyperlink148219()\"><span style=\"font-size:10pt; color: rgb(0, 120, 228);\">www.vetworks.eu</span></a><span style=\"font-size:10pt; color: rgb(0, 0, 0);\"> </span></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 285px; top: 420px; width: 227px; height: 102px; z-index: 41;",
	cssClasses:	"",
	htmlId:		"tobj148213",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 4"
	},
	objData:	{"a":[0,0,0,[285,420,227,102]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":366,"y":420,"width":292,"height":131},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148214.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148214Img\" src=\"images/close-hover.png\" style=\"position: absolute; left: 0px; top: 0px; width: 17px; height: 17px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 747px; top: 70px; width: 17px; height: 17px; z-index: 42; cursor: pointer;",
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
	objData:	{"a":[4,256,0,[747,70,17,17]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":960,"y":70,"width":22,"height":22},"res":"images/close-hover.png","resClick":"images/close-hover.png","resOver":"images/close149175.png"}
};
rcdObj.rcdData.att_TabletPortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_TabletPortrait = pgWidth_tabletPort;
rcdObj.preload_TabletPortrait = ["images/logo-vetworks-colfon.gif","images/logo-RB-colofon.gif","images/32.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-trans.png","images/correct.png","images/colofon.png","images/colofon-h.png","images/leren-H.png","images/close-hover.png","images/close149175.png","images/kaft-water-en-strooisel.jpg","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_TabletPortrait = 'position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_TabletPortrait = ["#FFFFFF","",0,0,1];
