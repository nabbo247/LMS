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
	objData:	{"a":[0,32,0,[-0.5000000000017053,-0.49999999999744205,785,473]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 785 0 L 785 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 2.8777e-12px; width: 785px; height: 35px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,2.8776980798284058e-12,785,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.00000000000288,783,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
image148817.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148817Img\" src=\"images/logo-Aeres.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 109px; height: 47px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 643px; top: 9px; width: 109px; height: 47px; z-index: 6;",
	cssClasses:	"",
	htmlId:		"tobj148817",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-Aeres"
	},
	objData:	{"a":[0,288,0,[643,9,109,47]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":826,"y":9,"width":140,"height":61}}
};
button352.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj352Img\" src=\"images/prev.png\" style=\"position: absolute; left: 0px; top: 0px; width: 26px; height: 26px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 19px; top: 554px; width: 26px; height: 26px; z-index: 62; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page143219.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[19,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
progress70386.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 238px; height: 5px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 238px; height: 3px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 240px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 273px; top: 571px; width: 240px; height: 5px; z-index: 63;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[273,571,240,5]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":30,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
};
text354.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 669px; min-height: 31px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 669px; min-height: 31px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span><strong><span style=\"font-size:22pt; color: rgb(255, 255, 255); font-family: calibri;\">Vleeskuikensignalen -&nbsp;</span></strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:22pt;\">Water en strooisel</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 5px; width: 669px; height: 31px; z-index: 7;",
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
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 47px; width: 700px; height: 26px; z-index: 8;",
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
text146548.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 703px; min-height: 21px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 703px; min-height: 21px;\"><p leglh=\"1.218\" style=\"margin-left:0px;text-indent:0px;line-height:1.218;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span style=\"font-size:14pt; font-family: calibri;\"><strong><span style=\"color: rgb(0, 0, 0);\">Title of Page</span></strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000; \"><strong> </strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000;\"> </span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 97px; width: 703px; height: 21px; z-index: 64;",
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
	objData:	{"a":[0,96,0,[39,97,703,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":97,"width":903,"height":27},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148245.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148245Img\" src=\"images/btn-home.png\" style=\"position: absolute; left: 0px; top: 0px; width: 22px; height: 19px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 8px; top: 10px; width: 22px; height: 19px; z-index: 65; cursor: pointer;",
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
	objData:	{"a":[4,352,0,[8,10,22,19]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":10,"y":10,"width":28,"height":25},"res":"images/btn-home.png","resClick":"images/btn-home.png","resOver":"images/btn-home-H.png"}
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
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; z-index: 66;",
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
	cssText:	"visibility: inherit; position: absolute; left: 194px; top: 100px; width: 397px; height: 397px; z-index: 67;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[194,100,397,397]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
button148771.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj148771Img\" src=\"images/next-close.png\" style=\"position: absolute; left: 0px; top: 0px; width: 26px; height: 26px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 738px; top: 554px; width: 26px; height: 26px; z-index: 68; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj148771",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next-close",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page148159.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[738,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next-close.png","resClick":"images/next-close.png","resOver":"images/next-close-H.png"}
};
shape147941.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 710 93\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(355 46.5)\" style=\"\">\n	<path d=\"M 0 0 L 710 0 L 710 93 L 0 93 L 0 0 Z\" style=\"stroke: rgb(102, 102, 102); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-355, -46.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(355 46.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"-353\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 172px; width: 710px; height: 93px; z-index: 9; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj147941",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle 2"
	},
	objData:	{"a":[0,32,0,[39,172.00000000000009,710,93]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":172,"width":912,"height":119},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape147941.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
image146964.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146964Img\" src=\"images/strooisel-tabel-dd.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 710px; height: 189px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 40px; top: 300px; width: 710px; height: 189px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj146964",
	bInsAnc:	0,
	cwObj:		{
		"name":	"strooisel-tabel-dd"
	},
	objData:	{"a":[0,288,0,[40,300,710,189]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":300,"width":912,"height":243}}
};
text146988.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 443px; min-height: 21px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 443px; min-height: 21px;\"><p style=\"text-align:left\"><span><strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\">Voorbeelden van strooiseltypes</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 40px; top: 302px; width: 443px; height: 21px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj146988",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[40,302,443,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":302,"width":570,"height":27},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
shape147940.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 724 109\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(362 54.5)\" style=\"\">\n	<path d=\"M 0 0 L 724 0 L 724 109 L 0 109 L 0 0 Z\" style=\"stroke: rgb(102, 102, 102); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-362, -54.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(362 54.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"-360\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 38px; top: 408px; width: 724px; height: 109px; z-index: 12; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj147940",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[38,408.0000000000001,724,109]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":49,"y":408,"width":931,"height":140},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape147940.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
button146952.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146952Img\" src=\"images/btn-submit.png\" style=\"position: absolute; left: 0px; top: 0px; width: 130px; height: 23px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 41px; top: 460px; width: 130px; height: 23px; z-index: 69; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146952",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-submit",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkRunActGrp',actItem:function(){ if(!VarQuestion_146989.equals('~~~null~~~')){og146958.issueActions(1001);}else if(typeof pF == 'function') pF();
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[41,460,130,23]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":53,"y":460,"width":167,"height":30},"res":"images/btn-submit.png","resClick":"images/btn-submit.png","resOver":"images/btn-submit-H.png"}
};
og146955.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og146955",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text146956.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; height: 27px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 700px; height: 27px;\"><p><span style=\"font-family: calibri; font-size:12pt; color: rgb(0, 158, 15);\">Dit is&nbsp;correct.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 513px; width: 708px; height: 35px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj146956",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB1"
	},
	objData:	{"a":[0,0,0,[39,513,708,27]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":513,"width":910,"height":32},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text146957.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; height: 27px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 700px; height: 27px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Dit is niet correct. Probeer het nogmaals</span><span style=\"color: rgb(207, 42, 39); font-family: calibri; font-size:12pt;\">.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 513px; width: 708px; height: 35px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj146957",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB2"
	},
	objData:	{"a":[0,0,0,[39,513,708,27]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":513,"width":910,"height":32},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
image147966.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147966Img\" src=\"images/correct-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 118px; top: 327px; width: 20px; height: 20px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj147966",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-dd 1"
	},
	objData:	{"a":[0,256,0,[118,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":152,"y":327,"width":26,"height":26}}
};
image147967.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147967Img\" src=\"images/correct-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 219px; top: 327px; width: 20px; height: 20px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj147967",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-dd 2"
	},
	objData:	{"a":[0,256,0,[219,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":282,"y":327,"width":26,"height":26}}
};
image147971.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147971Img\" src=\"images/correct-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 321px; top: 327px; width: 20px; height: 20px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj147971",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-dd 3"
	},
	objData:	{"a":[0,256,0,[321,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":412,"y":327,"width":26,"height":26}}
};
image147975.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147975Img\" src=\"images/correct-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 422px; top: 327px; width: 20px; height: 20px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj147975",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-dd 4"
	},
	objData:	{"a":[0,256,0,[422,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":542,"y":327,"width":26,"height":26}}
};
image147979.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147979Img\" src=\"images/correct-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 523px; top: 327px; width: 20px; height: 20px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj147979",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-dd 5"
	},
	objData:	{"a":[0,256,0,[523,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":672,"y":327,"width":26,"height":26}}
};
image147983.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147983Img\" src=\"images/correct-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 625px; top: 327px; width: 20px; height: 20px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj147983",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-dd 6"
	},
	objData:	{"a":[0,256,0,[625,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":803,"y":327,"width":26,"height":26}}
};
image147987.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147987Img\" src=\"images/correct-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 727px; top: 327px; width: 20px; height: 20px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj147987",
	bInsAnc:	0,
	cwObj:		{
		"name":	"correct-dd 7"
	},
	objData:	{"a":[0,256,0,[727,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":934,"y":327,"width":26,"height":26}}
};
image147993.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147993Img\" src=\"images/false-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 118px; top: 327px; width: 20px; height: 20px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj147993",
	bInsAnc:	0,
	cwObj:		{
		"name":	"false-dd 1"
	},
	objData:	{"a":[0,256,0,[118,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":152,"y":327,"width":26,"height":26}}
};
image147994.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147994Img\" src=\"images/false-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 219px; top: 327px; width: 20px; height: 20px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj147994",
	bInsAnc:	0,
	cwObj:		{
		"name":	"false-dd 2"
	},
	objData:	{"a":[0,256,0,[219,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":282,"y":327,"width":26,"height":26}}
};
image147995.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147995Img\" src=\"images/false-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 321px; top: 327px; width: 20px; height: 20px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj147995",
	bInsAnc:	0,
	cwObj:		{
		"name":	"false-dd 3"
	},
	objData:	{"a":[0,256,0,[321,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":412,"y":327,"width":26,"height":26}}
};
image147996.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147996Img\" src=\"images/false-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 422px; top: 327px; width: 20px; height: 20px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj147996",
	bInsAnc:	0,
	cwObj:		{
		"name":	"false-dd 4"
	},
	objData:	{"a":[0,256,0,[422,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":542,"y":327,"width":26,"height":26}}
};
image147997.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147997Img\" src=\"images/false-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 523px; top: 327px; width: 20px; height: 20px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj147997",
	bInsAnc:	0,
	cwObj:		{
		"name":	"false-dd 5"
	},
	objData:	{"a":[0,256,0,[523,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":672,"y":327,"width":26,"height":26}}
};
image147998.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147998Img\" src=\"images/false-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 625px; top: 327px; width: 20px; height: 20px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj147998",
	bInsAnc:	0,
	cwObj:		{
		"name":	"false-dd 6"
	},
	objData:	{"a":[0,256,0,[625,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":803,"y":327,"width":26,"height":26}}
};
image147999.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147999Img\" src=\"images/false-dd.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 20px; height: 20px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 727px; top: 327px; width: 20px; height: 20px; z-index: 28;",
	cssClasses:	"",
	htmlId:		"tobj147999",
	bInsAnc:	0,
	cwObj:		{
		"name":	"false-dd 7"
	},
	objData:	{"a":[0,256,0,[727,327,20,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":934,"y":327,"width":26,"height":26}}
};
og146958.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og146958",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146962.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; min-height: 36px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 708px; min-height: 36px;\"><p><span><strong><span style=\"font-family: calibri; font-size:12pt;\">De belangrijkste eigenschappen voor strooisel zijn het vochtabsorberend vermogen en de afwezigheid van stof. Herken jij de kenmerken van de verschillende strooiseltypen? </span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 125px; width: 708px; height: 36px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj146962",
	bInsAnc:	0,
	cwObj:		{
		"name":	"header"
	},
	objData:	{"a":[0,32,0,[39,125,708,36]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":910,"height":46},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147939.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147939",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text146965.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 384px; width: 100px; height: 19px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj146965",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[39,384,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":384,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146966.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 430px; width: 100px; height: 19px; z-index: 31;",
	cssClasses:	"",
	htmlId:		"tobj146966",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[39,430,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":430,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146967.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 140px; top: 384px; width: 100px; height: 19px; z-index: 32;",
	cssClasses:	"",
	htmlId:		"tobj146967",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[140,384,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":180,"y":384,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146968.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 241px; top: 430px; width: 100px; height: 19px; z-index: 33;",
	cssClasses:	"",
	htmlId:		"tobj146968",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[241,430,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":310,"y":430,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146969.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 342px; top: 384px; width: 100px; height: 19px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj146969",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[342,384,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":440,"y":384,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146970.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 443px; top: 430px; width: 100px; height: 19px; z-index: 35;",
	cssClasses:	"",
	htmlId:		"tobj146970",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[443,430,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":570,"y":430,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146971.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align:center\"><span style=\"font-family:\'Arial\',sans-serif;font-size:12pt;color:0\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 545px; top: 384px; width: 100px; height: 19px; z-index: 36;",
	cssClasses:	"",
	htmlId:		"tobj146971",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[545,384,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":700,"y":384,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146972.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 647px; top: 430px; width: 100px; height: 19px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj146972",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[647,430,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":831,"y":430,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146973.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 647px; top: 384px; width: 100px; height: 19px; z-index: 38;",
	cssClasses:	"",
	htmlId:		"tobj146973",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[647,384,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":831,"y":384,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146974.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 545px; top: 430px; width: 100px; height: 19px; z-index: 39;",
	cssClasses:	"",
	htmlId:		"tobj146974",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[545,430,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":700,"y":430,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146975.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 31px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 31px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p><p style=\"text-align: center;\"><span>&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 443px; top: 384px; width: 100px; height: 31px; z-index: 40;",
	cssClasses:	"",
	htmlId:		"tobj146975",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[443,384,100,31]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":570,"y":384,"width":129,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146976.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align:center\"><span style=\"font-family:\'Arial\',sans-serif;font-size:12pt;color:0\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 342px; top: 430px; width: 100px; height: 19px; z-index: 41;",
	cssClasses:	"",
	htmlId:		"tobj146976",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[342,430,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":440,"y":430,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146977.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 241px; top: 384px; width: 100px; height: 19px; z-index: 42;",
	cssClasses:	"",
	htmlId:		"tobj146977",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[241,384,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":310,"y":384,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146978.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 140px; top: 430px; width: 100px; height: 19px; z-index: 43;",
	cssClasses:	"",
	htmlId:		"tobj146978",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 10"
	},
	objData:	{"a":[0,0,0,[140,430,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":180,"y":430,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146979.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 709px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 709px; min-height: 19px;\"><p style=\"text-align: center;\"><strong><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">&nbsp;Vochtabsorberend vermogen&nbsp;+ = goed, absorberend vermogen</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 360px; width: 709px; height: 19px; z-index: 44;",
	cssClasses:	"",
	htmlId:		"tobj146979",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 5"
	},
	objData:	{"a":[0,0,0,[39,360,709,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":360,"width":911,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146980.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 710px; min-height: 18px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 710px; min-height: 18px;\"><p style=\"text-align: center;\"><strong><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">Gehalte stofdeeltjes&nbsp;+ = goed, weinig stof</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 406px; width: 710px; height: 18px; z-index: 45;",
	cssClasses:	"",
	htmlId:		"tobj146980",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 6"
	},
	objData:	{"a":[0,0,0,[39,406,710,18]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":406,"width":912,"height":23},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146981.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Gehakseld stro</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 44px; top: 334px; width: 89px; height: 23px; z-index: 46;",
	cssClasses:	"",
	htmlId:		"tobj146981",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[44,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":57,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146982.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Tarwestro</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 144px; top: 334px; width: 89px; height: 23px; z-index: 47;",
	cssClasses:	"",
	htmlId:		"tobj146982",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[144,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":185,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146983.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Houtkrullen</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 246px; top: 334px; width: 89px; height: 23px; z-index: 48;",
	cssClasses:	"",
	htmlId:		"tobj146983",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[246,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":316,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146984.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Zaagsel</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 347px; top: 334px; width: 89px; height: 23px; z-index: 49;",
	cssClasses:	"",
	htmlId:		"tobj146984",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[347,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":446,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146985.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Gehakseld vlas</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 448px; top: 334px; width: 89px; height: 23px; z-index: 50;",
	cssClasses:	"",
	htmlId:		"tobj146985",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[448,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":576,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146986.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Rijstkaf</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 549px; top: 334px; width: 89px; height: 23px; z-index: 51;",
	cssClasses:	"",
	htmlId:		"tobj146986",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[549,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":706,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146987.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 96px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 96px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Zonnebloemhulzen</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 649px; top: 334px; width: 96px; height: 23px; z-index: 52;",
	cssClasses:	"",
	htmlId:		"tobj146987",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,0,0,[649,334,96,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":834,"y":334,"width":124,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
qu146989.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu146989",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"#0000FF",
				"questType":	7,
				"dwQuestFlags":	8,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0031\\u002D\\u0031","\\u0032\\u002D\\u0032","\\u0033\\u002D\\u0033","\\u0034\\u002D\\u0034","\\u0035\\u002D\\u0035","\\u0036\\u002D\\u0036","\\u0037\\u002D\\u0037"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"dragDropInitFunc":	function() { dragMgr.bSnapToCenter = true;
			dragMgr.addDrop( 49, 407, 86, 29, '1', qu146989, 99 );
			dragMgr.addDrop( 149, 407, 86, 29, '2', qu146989, 99 );
			dragMgr.addDrop( 251, 407, 86, 29, '3', qu146989, 99 );
			dragMgr.addDrop( 351, 407, 86, 29, '4', qu146989, 99 );
			dragMgr.addDrop( 453, 407, 86, 29, '5', qu146989, 99 );
			dragMgr.addDrop( 555, 407, 86, 29, '6', qu146989, 99 );
			dragMgr.addDrop( 658, 407, 86, 29, '7', qu146989, 99 );
			dragMgr.addDrag( text146992, '1', qu146989 );
			dragMgr.addDrag( text146993, '2', qu146989 );
			dragMgr.addDrag( text146994, '3', qu146989 );
			dragMgr.addDrag( text146995, '4', qu146989 );
			dragMgr.addDrag( text146996, '5', qu146989 );
			dragMgr.addDrag( text146997, '6', qu146989 );
			dragMgr.addDrag( text146998, '7', qu146989 );
}
			,
				"correctAnswerNum":	7,
				"varQuest":	VarQuestion_146989
	},
	objData:	{"a":[0,32,0,[]]}
};
text146990.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 654px; min-height: 24px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 654px; min-height: 24px;\"><p align=\"left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Sleep het juiste strooiseltype naar de juiste plek.&nbsp;</span></strong></span></p></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 44px; top: 178px; width: 654px; height: 24px; z-index: 53;",
	cssClasses:	"",
	htmlId:		"tobj146990",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[44,178,654,24]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":57,"y":178,"width":840,"height":31},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image146991.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146991Img\" src=\"images/bg-dd-strooiseltabel.gif\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 713px; height: 28px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 407px; width: 713px; height: 28px; z-index: 54;",
	cssClasses:	"",
	htmlId:		"tobj146991",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Question image"
	},
	objData:	{"a":[0,288,0,[39,407,713,28]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":407,"width":916,"height":36}}
};
text146992.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 103px; height: 33px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 103px; height: 33px;\"><p style=\"text-align: center; line-height: 32px; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Gehakseld stro</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 389px; top: 249px; width: 103px; height: 41px; z-index: 55; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146992",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Choice 1 text"
	},
	objData:	{"a":[0,32,0,[389,249,103,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":500,"y":249,"width":132,"height":36},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146993.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 103px; height: 34px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 103px; height: 34px;\"><p style=\"text-align: center; line-height: 32px; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:13pt;\">Tarwestro</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 52px; top: 205px; width: 103px; height: 42px; z-index: 56; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146993",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Choice 2 text"
	},
	objData:	{"a":[0,32,0,[52,205,103,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":67,"y":205,"width":132,"height":36},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146994.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 103px; height: 33px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 103px; height: 33px;\"><p style=\"text-align: center; line-height: 32px; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Houtkrullen</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 120px; top: 249px; width: 103px; height: 41px; z-index: 57; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146994",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Choice 3 text"
	},
	objData:	{"a":[0,32,0,[120,249,103,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":154,"y":249,"width":132,"height":36},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146995.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 103px; height: 33px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 103px; height: 33px;\"><p style=\"text-align: center; line-height: 32px; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Zaagsel</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 255px; top: 249px; width: 103px; height: 41px; z-index: 58; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146995",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Choice 4 text"
	},
	objData:	{"a":[0,32,0,[255,249,103,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":328,"y":249,"width":132,"height":36},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146996.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 103px; height: 33px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 103px; height: 33px;\"><p style=\"text-align: center; line-height: 32px; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Gehakseld vlas</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 462px; top: 204px; width: 103px; height: 41px; z-index: 59; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146996",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Choice 5 text"
	},
	objData:	{"a":[0,32,0,[462,204,103,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":594,"y":204,"width":132,"height":36},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146997.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 103px; height: 33px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 103px; height: 33px;\"><p style=\"text-align: center; line-height: 32px; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Rijstkaf</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 321px; top: 204px; width: 103px; height: 41px; z-index: 60; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146997",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Choice 6 text"
	},
	objData:	{"a":[0,32,0,[321,204,103,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":413,"y":204,"width":132,"height":36},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146998.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 103px; height: 33px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 103px; height: 33px;\"><p style=\"text-align: center; line-height: 32px; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Zonnebloemhulzen</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 187px; top: 204px; width: 103px; height: 41px; z-index: 61; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146998",
	bInsAnc:	0,
	fieldsetId:	'fset146989',
	cwObj:		{
		"name":	"Choice 7 text"
	},
	objData:	{"a":[0,32,0,[187,204,103,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":240,"y":204,"width":132,"height":36},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_TabletPortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_TabletPortrait = pgWidth_tabletPort;
rcdObj.preload_TabletPortrait = ["images/prev.png","images/prevHover.png","images/btn-submit.png","images/btn-submit-H.png","images/indicatie.gif","images/btn-close143187.png","images/btn-close-hover143188.png","images/bg-dd-strooiseltabel.gif","images/strooisel-tabel-dd.jpg","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/correct-dd.png","images/false-dd.png","images/next-close.png","images/next-close-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_TabletPortrait = 'position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_TabletPortrait = ["#FFFFFF","",0,0,1];
