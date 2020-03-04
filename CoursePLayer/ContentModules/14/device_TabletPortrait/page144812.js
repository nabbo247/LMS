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
	objData:	{"a":[0,32,0,[-0.5000000000007958,-0.4999999999988063,785,473]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 785 0 L 785 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.34293e-12px; width: 785px; height: 35px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.3429257705865894e-12,785,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.00000000000134,783,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 19px; top: 554px; width: 26px; height: 26px; z-index: 24; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144805.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[19,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 26px; height: 26px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 738px; top: 554px; width: 26px; height: 26px; z-index: 25; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144758.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[738,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 238px; height: 5px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 238px; height: 3px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 112px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 273px; top: 571px; width: 240px; height: 5px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[273,571,240,5]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":14,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 97px; width: 703px; height: 21px; z-index: 27;",
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
	cssText:	"visibility: inherit; position: absolute; left: 8px; top: 10px; width: 22px; height: 19px; z-index: 28; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; z-index: 29;",
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
	cssText:	"visibility: inherit; position: absolute; left: 194px; top: 100px; width: 397px; height: 397px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[194,100,397,397]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
shape147610.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 312 199\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(156 99.5)\" style=\"\">\n	<path d=\"M 0 0 L 312 0 L 312 199 L 0 199 L 0 0 Z\" style=\"stroke: rgb(102, 102, 102); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-156, -99.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(156 99.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"-154\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 40px; top: 185px; width: 312px; height: 199px; z-index: 9; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj147610",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[39.99999999999997,185.00000000000006,312,199]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":185,"width":401,"height":256},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape147610.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
button147602.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147602Img\" src=\"images/btn-submit.png\" style=\"position: absolute; left: 0px; top: 0px; width: 130px; height: 23px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 451px; width: 130px; height: 23px; z-index: 31; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147602",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-submit",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkRunActGrp',actItem:function(){ if(!VarQuestion_147567.equals('~~~null~~~')){og147593.issueActions(1001);}else if(typeof pF == 'function') pF();
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[39,451,130,23]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":451,"width":167,"height":30},"res":"images/btn-submit.png","resClick":"images/btn-submit.png","resOver":"images/btn-submit-H.png"}
};
og147599.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147599",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text147600.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 700px; height: 42px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 692px; height: 34px;\"><p><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Niet correct. Als eerste vul je de leiding met desinfectiemiddel.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 493px; width: 700px; height: 42px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj147600",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB1"
	},
	objData:	{"a":[0,0,0,[39,493,700,42]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":493,"width":900,"height":54},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147614.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; height: 51px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 700px; height: 51px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Niet correct. Na het vullen van de leiding met desinfectiemiddel moet je elke nippel even aanraken om er zeker van te zijn dat alle nippels gevuld zijn met desinfectiemiddel.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 493px; width: 708px; height: 59px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj147614",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB2"
	},
	objData:	{"a":[0,0,0,[39,493,708,51]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":493,"width":910,"height":54},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147618.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; height: 51px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 700px; height: 51px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Niet correct. Als je zeker weet dat alle nippels zijn gevuld met desinfectiemiddel, dan laat je het 24 uur lang zitten.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 493px; width: 708px; height: 59px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj147618",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB3"
	},
	objData:	{"a":[0,0,0,[39,493,708,51]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":493,"width":910,"height":54},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147622.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; height: 51px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 700px; height: 51px;\"><p><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Niet correct. Als je het desinfectiemiddel 24 uur hebt laten zitten dan controleer je de binnenkant van de waterleidingen en voorraadtanks.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 493px; width: 708px; height: 59px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj147622",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB4"
	},
	objData:	{"a":[0,0,0,[39,493,708,51]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":493,"width":910,"height":54},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147626.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; height: 51px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 700px; height: 51px;\"><p><span style=\"font-family: calibri; font-size:12pt; color: rgb(207, 42, 39);\">Niet correct. Als laatste stap spoel je de leiding met hoge druk door en raak je elke nippel nogmaals aan zodat er geen desinfectiemiddel in de leiding achter blijft.&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 493px; width: 708px; height: 59px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj147626",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB5"
	},
	objData:	{"a":[0,0,0,[39,493,708,51]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":493,"width":910,"height":54},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147601.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 708px; height: 42px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 700px; height: 34px;\"><p style=\"text-align:left\"><span style=\"color: rgb(0, 158, 15); font-family: calibri; font-size:12pt;\">Correct.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 493px; width: 708px; height: 42px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj147601",
	bInsAnc:	0,
	cwObj:		{
		"name":	"FB6"
	},
	objData:	{"a":[0,0,0,[39,493,708,42]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":493,"width":910,"height":54},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
og147593.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147593",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
qu147567.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"qu147567",
	bInsAnc:	undefined,
	cwObj:		{
				"crLineColor":	"#0000FF",
				"questType":	7,
				"dwQuestFlags":	8,
				"doImmFeedback":	0,
				"maxAllowedAttempts":	0,
				"arrAns":	["\\u0031\\u002D\\u0031","\\u0032\\u002D\\u0032","\\u0033\\u002D\\u0033","\\u0034\\u002D\\u0034","\\u0035\\u002D\\u0035"],
				"correctFeedbackFunc":	0,
				"incorrectFeedbackFunc":	0,
				"attemptsFeedbackFunc":	0,
				"dragDropInitFunc":	function() { dragMgr.bSnapToCenter = true;
			dragMgr.addDrop( 141, 132, 400, 45, '1', qu147567, 99 );
			dragMgr.addDrop( 141, 185, 400, 45, '2', qu147567, 99 );
			dragMgr.addDrop( 139, 239, 400, 47, '3', qu147567, 99 );
			dragMgr.addDrop( 141, 292, 400, 49, '4', qu147567, 99 );
			dragMgr.addDrop( 139, 346, 402, 49, '5', qu147567, 99 );
			dragMgr.addDrag( text147583, '1', qu147567 );
			dragMgr.addDrag( text147584, '2', qu147567 );
			dragMgr.addDrag( text147585, '3', qu147567 );
			dragMgr.addDrag( text147586, '4', qu147567 );
			dragMgr.addDrag( text147587, '5', qu147567 );
}
			,
				"correctAnswerNum":	5,
				"varQuest":	VarQuestion_147567
	},
	objData:	{"a":[0,32,0,[]]}
};
text147582.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 113px; min-height: 20px;\"><legend><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 113px; min-height: 20px;\"><p align=\"left\"><span><strong><span style=\"color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Zet de onderstaande acties in de juiste volgorde door ze naar de juiste plek in de tabel te plaatsen en controleer je antwoord.&nbsp;</span></strong></span></p></div></legend></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 100px; width: 113px; height: 20px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj147582",
	bInsAnc:	0,
	fieldsetId:	'fset147567',
	cwObj:		{
		"name":	"Question Text"
	},
	objData:	{"a":[0,32,0,[50,100,113,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":154,"width":918,"height":26},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image147581.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147581Img\" src=\"images/dd-bg-volgorde.gif\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 441px; height: 264px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 100px; top: 130px; width: 441px; height: 264px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj147581",
	bInsAnc:	0,
	fieldsetId:	'fset147567',
	cwObj:		{
		"name":	"Question image",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ og147599.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[1,288,0,[100,130,441,264]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":521,"y":185,"width":441,"height":264}}
};
text147583.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 97px; height: 71px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 89px; height: 71px;\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Vul de leiding met desinfectiemiddel.</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 130px; width: 97px; height: 79px; z-index: 18; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147583",
	bInsAnc:	0,
	fieldsetId:	'fset147567',
	cwObj:		{
		"name":	"Choice 1 text"
	},
	objData:	{"a":[0,32,0,[50,130,97,71]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":290,"width":400,"height":46},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147584.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 97px; height: 131px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 89px; height: 131px;\"><p align=\"left\"><span style=\"font-family: Arial, sans-serif; font-size:12pt; color: rgb(255, 255, 255);\"><span style=\"font-size:12pt; font-family: calibri; color: rgb(255, 255, 255);\">Raak elke nippel even aan zodat elke nip</span><span style=\"font-size:12pt; font-family: calibri; color: rgb(255, 255, 255);\">pel gevuld is met desinfectiemiddel.</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 160px; width: 97px; height: 139px; z-index: 19; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147584",
	bInsAnc:	0,
	fieldsetId:	'fset147567',
	cwObj:		{
		"name":	"Choice 2 text"
	},
	objData:	{"a":[0,32,0,[50,160,97,131]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":394,"width":400,"height":46},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147585.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 97px; height: 71px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 89px; height: 71px;\"><p align=\"left\"><span style=\"font-family: calibri; color: rgb(255, 255, 255); font-size:12pt;\">Laat het 24 uur lang zitten.</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 190px; width: 97px; height: 79px; z-index: 20; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147585",
	bInsAnc:	0,
	fieldsetId:	'fset147567',
	cwObj:		{
		"name":	"Choice 3 text"
	},
	objData:	{"a":[0,32,0,[50,190,97,71]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":238,"width":400,"height":46},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147586.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 97px; height: 150px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 89px; height: 150px;\"><p style=\"text-align:left\"><span style=\"color: rgb(255, 255, 255); font-family: Arial, sans-serif; font-size:12pt;\"><span style=\"font-size:12pt; font-family: calibri;\">Controleer de binnenkant van de waterlei</span><span style=\"font-size:12pt; font-family: calibri;\">dingen en de voorraadtanks.</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 220px; width: 97px; height: 158px; z-index: 21; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147586",
	bInsAnc:	0,
	fieldsetId:	'fset147567',
	cwObj:		{
		"name":	"Choice 4 text"
	},
	objData:	{"a":[0,32,0,[50,220,97,150]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":342,"width":400,"height":46},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147587.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; cursor: pointer; width: 97px; height: 228px; background-color: rgb(69, 143, 208);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 89px; height: 228px;\"><p align=\"left\"><span><span style=\"color: rgb(255, 255, 255); font-family: Arial, sans-serif; font-size:12pt;\"><span style=\"font-size:12pt; font-family: calibri;\">Spoel de leiding met hoge druk door, raak&nbsp;</span><span style=\"font-size:12pt; font-family: calibri;\">elke nippel nogmaals aan zodat er geen desinfectiemiddel achterblijft.&nbsp;</span></span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 250px; width: 97px; height: 236px; z-index: 22; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147587",
	bInsAnc:	0,
	fieldsetId:	'fset147567',
	cwObj:		{
		"name":	"Choice 5 text"
	},
	objData:	{"a":[0,32,0,[50,250,97,228]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":52,"y":186,"width":400,"height":46},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text144813.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 714px; min-height: 47px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 714px; min-height: 47px;\"><p style=\"font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span><strong><span style=\"color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Het schoonmaken van waterleidingen kun je het beste in een vaste volgorde doen.&nbsp;Weet jij de juiste volgorde? ​</span></strong></span></p><p style=\"font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span>​</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 125px; width: 714px; height: 47px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj144813",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[39,125,714,47]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":918,"height":60},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_TabletPortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_TabletPortrait = pgWidth_tabletPort;
rcdObj.preload_TabletPortrait = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/btn-submit.png","images/btn-submit-H.png","images/indicatie.gif","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/dd-bg-volgorde.gif","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_TabletPortrait = 'position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_TabletPortrait = ["#FFFFFF","",0,0,1];
