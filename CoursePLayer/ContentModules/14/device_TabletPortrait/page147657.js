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
	objData:	{"a":[0,32,0,[-0.5000000000010232,-0.4999999999984652,785,473]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 785 0 L 785 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.72662e-12px; width: 785px; height: 35px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.7266188478970435e-12,785,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.00000000000173,783,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 19px; top: 554px; width: 26px; height: 26px; z-index: 25; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page138155.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[19,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 26px; height: 26px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 738px; top: 554px; width: 26px; height: 26px; z-index: 26; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page137673.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[738,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 238px; height: 5px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 238px; height: 3px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 144px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 273px; top: 571px; width: 240px; height: 5px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[273,571,240,5]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":18,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 97px; width: 703px; height: 21px; z-index: 28;",
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
	cssText:	"visibility: inherit; position: absolute; left: 8px; top: 10px; width: 22px; height: 19px; z-index: 29; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; z-index: 30;",
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
	cssText:	"visibility: inherit; position: absolute; left: 194px; top: 100px; width: 397px; height: 397px; z-index: 31;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[194,100,397,397]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
image147676.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147676Img\" src=\"images/CIMG3134%2C-EM.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 342px; height: 176px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 405px; top: 125px; width: 342px; height: 176px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj147676",
	bInsAnc:	0,
	cwObj:		{
		"name":	"CIMG3134,-EM"
	},
	objData:	{"a":[0,288,0,[405,125,342,176]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":520,"y":125,"width":440,"height":226}}
};
image147720.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147720Img\" src=\"images/P1110021-JS-knik-in-nippelleiding.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 346px; height: 177px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 125px; width: 346px; height: 177px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj147720",
	bInsAnc:	0,
	cwObj:		{
		"name":	"P1110021-JS-knik-in-nippelleiding"
	},
	objData:	{"a":[0,288,0,[39,125,346,177]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":445,"height":228}}
};
shape148596.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 196 82\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(98 41)\" style=\"\">\n	<path d=\"M 0 39.5 A 96.5 39.5 0 1 1 193 39.5 A 96.5 39.5 0 1 1 0 39.5 Z\" style=\"stroke: rgb(255, 255, 0); stroke-width: 3; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-96.5, -39.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(98 41)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.998963405595857\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.09\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 112.5px; top: 115.5px; width: 196px; height: 82px; z-index: 11; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj148596",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Ellipse"
	},
	objData:	{"a":[0,0,0,[112.49999999999999,115.50000000000003,196,82]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":146,"y":117,"width":251,"height":105},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape148596.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og147656.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147656",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
button147698.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147698Img\" src=\"images/button-kijk.png\" style=\"position: absolute; left: 0px; top: 0px; width: 25px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 36px; top: 820px; width: 25px; height: 25px; z-index: 32; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147698",
	bInsAnc:	1,
	cwObj:		{
		"name":	"button-kijk",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkToggleVis',actItem:function(){ text147691.toggleVisibility(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkToggleVis',actItem:function(){ shape148596.toggleVisibility(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,6496,0,[36,820,25,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":963,"y":232,"width":32,"height":32},"res":"images/button-kijk.png","resClick":"images/button-kijk-H.png","resOver":"images/button-kijk-H.png"}
};
button147696.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147696Img\" src=\"images/button-denk.png\" style=\"position: absolute; left: 0px; top: 0px; width: 25px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 36px; top: 853px; width: 25px; height: 25px; z-index: 33; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147696",
	bInsAnc:	1,
	cwObj:		{
		"name":	"button-denk",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkToggleVis',actItem:function(){ text147689.toggleVisibility(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,6496,0,[36,853,25,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":963,"y":189,"width":32,"height":32},"res":"images/button-denk.png","resClick":"images/button-denk-H.png","resOver":"images/button-denk-H.png"}
};
button147694.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147694Img\" src=\"images/button-act.png\" style=\"position: absolute; left: 0px; top: 0px; width: 25px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 36px; top: 890px; width: 25px; height: 25px; z-index: 34; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147694",
	bInsAnc:	1,
	cwObj:		{
		"name":	"button-act",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkToggleVis',actItem:function(){ text147687.toggleVisibility(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,6496,0,[36,890,25,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":963,"y":142,"width":32,"height":32},"res":"images/button-act.png","resClick":"images/btn-act-H.png","resOver":"images/btn-act-H.png"}
};
text147693.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 707px; min-height: 47px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 707px; min-height: 47px;\"><p><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Bekijk de bovenstaande foto\'s, stel jezelf de onderstaande vragen en klik op de icoontjes voor de antwoorden.</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 40px; top: 353px; width: 707px; height: 47px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj147693",
	bInsAnc:	0,
	cwObj:		{
		"name":	"vraag"
	},
	objData:	{"a":[0,32,0,[40,353,707,47]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":51,"y":353,"width":909,"height":60},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147692.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 156px; min-height: 17px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 156px; min-height: 17px;\"><p style=\"line-height: 1.5; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:12pt;\">​Wat zie ik? &nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 67px; top: 382px; width: 156px; height: 17px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj147692",
	bInsAnc:	0,
	cwObj:		{
		"name":	"01"
	},
	objData:	{"a":[0,32,0,[67,382,156,17]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":86,"y":382,"width":200,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147691.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 313px; height: 43px; background-color: rgb(255, 255, 255);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 313px; height: 43px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">Deze drinklijn is doorgebogen en lijkt te lekken op de doorgebogen plek.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 67px; top: 375px; width: 313px; height: 51px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj147691",
	bInsAnc:	0,
	cwObj:		{
		"name":	"01-antw"
	},
	objData:	{"a":[0,0,0,[67,375,313,43]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":86,"y":375,"width":402,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147690.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 156px; min-height: 24px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 156px; min-height: 24px;\"><p style=\"line-height: 1.5; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:12pt;\">Wat betekent het?</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 67px; top: 425px; width: 156px; height: 24px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj147690",
	bInsAnc:	0,
	cwObj:		{
		"name":	"02"
	},
	objData:	{"a":[0,32,0,[67,425,156,24]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":86,"y":425,"width":200,"height":31},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147689.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 314px; height: 63px; background-color: rgb(255, 255, 255);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 314px; height: 63px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Op het laagste punt in de leiding zal vuil neerslaan waardoor de kans op het ontstaan van biofilm toeneemt.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 67px; top: 419px; width: 314px; height: 71px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj147689",
	bInsAnc:	0,
	cwObj:		{
		"name":	"02-antw"
	},
	objData:	{"a":[0,0,0,[67,419,314,63]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":86,"y":419,"width":404,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147688.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 156px; min-height: 30px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 156px; min-height: 30px;\"><p style=\"line-height: 1.5; margin-bottom: 0px; margin-top: 0px;\"><span><span style=\"font-family: arial; font-size:12pt;\"><span style=\"font-family: calibri; font-size:12pt;\">Wat moet ik doen?&nbsp;</span></span>​​​​​​​</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 67px; top: 473px; width: 156px; height: 30px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj147688",
	bInsAnc:	0,
	cwObj:		{
		"name":	"03"
	},
	objData:	{"a":[0,32,0,[67,473,156,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":86,"y":473,"width":200,"height":38},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147687.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 314px; height: 123px; background-color: rgb(255, 255, 255);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 314px; height: 123px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">Drinklijnen moeten horizontaal worden opgehangen. Vergeet niet om de hellingshoek van de stal te controleren. Een leiding die parallel loopt met de vloer hoeft niet waterpas te hangen. Ook dit kan&nbsp; drukverschillen en biofilm veroorzaken.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 67px; top: 464px; width: 314px; height: 131px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj147687",
	bInsAnc:	0,
	cwObj:		{
		"name":	"03-antw"
	},
	objData:	{"a":[0,0,0,[67,464,314,123]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":86,"y":464,"width":404,"height":80},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147721.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147721",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
button147704.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147704Img\" src=\"images/button-kijk.png\" style=\"position: absolute; left: 0px; top: 0px; width: 25px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 405px; top: 820px; width: 25px; height: 25px; z-index: 35; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147704",
	bInsAnc:	1,
	cwObj:		{
		"name":	"button-kijk",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkToggleVis',actItem:function(){ text147712.toggleVisibility(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,6496,0,[405,820,25,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":489,"y":232,"width":32,"height":32},"res":"images/button-kijk.png","resClick":"images/button-kijk-H.png","resOver":"images/button-kijk-H.png"}
};
button147706.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147706Img\" src=\"images/button-denk.png\" style=\"position: absolute; left: 0px; top: 0px; width: 25px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 405px; top: 853px; width: 25px; height: 25px; z-index: 36; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147706",
	bInsAnc:	1,
	cwObj:		{
		"name":	"button-denk",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkToggleVis',actItem:function(){ text147714.toggleVisibility(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,6496,0,[405,853,25,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":489,"y":189,"width":32,"height":32},"res":"images/button-denk.png","resClick":"images/button-denk-H.png","resOver":"images/button-denk-H.png"}
};
button147708.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147708Img\" src=\"images/button-act.png\" style=\"position: absolute; left: 0px; top: 0px; width: 25px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 405px; top: 905px; width: 25px; height: 25px; z-index: 37; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147708",
	bInsAnc:	1,
	cwObj:		{
		"name":	"button-act",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkToggleVis',actItem:function(){ text147716.toggleVisibility(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,6496,0,[405,905,25,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":489,"y":122,"width":32,"height":32},"res":"images/button-act.png","resClick":"images/btn-act-H.png","resOver":"images/btn-act-H.png"}
};
text147711.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 156px; min-height: 17px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 156px; min-height: 17px;\"><p style=\"line-height: 1.5; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:12pt;\">​Wat zie ik? &nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 436px; top: 382px; width: 156px; height: 17px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj147711",
	bInsAnc:	0,
	cwObj:		{
		"name":	"01"
	},
	objData:	{"a":[0,32,0,[436,382,156,17]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":560,"y":382,"width":200,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147712.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 313px; height: 43px; background-color: rgb(255, 255, 255);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 313px; height: 43px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">Deze lekbakjes zijn vervuild met strooisel en voer.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 436px; top: 382px; width: 313px; height: 51px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj147712",
	bInsAnc:	0,
	cwObj:		{
		"name":	"01-antw"
	},
	objData:	{"a":[0,0,0,[436,382,313,43]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":560,"y":382,"width":402,"height":33},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147713.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 156px; min-height: 17px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 156px; min-height: 17px;\"><p style=\"line-height: 1.5; margin-bottom: 0px; margin-top: 0px;\"><span style=\"font-family: calibri; font-size:12pt;\">Wat betekent het?</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 436px; top: 425px; width: 156px; height: 17px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj147713",
	bInsAnc:	0,
	cwObj:		{
		"name":	"02"
	},
	objData:	{"a":[0,32,0,[436,425,156,17]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":560,"y":425,"width":200,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147714.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 314px; height: 82px; background-color: rgb(255, 255, 255);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 314px; height: 82px;\"><p style=\"text-align: left; line-height: 1.25; margin-top: 0px; margin-bottom: 0px;\"><span style=\"font-family: calibri; font-size:12pt;\">Vervuilde lekbakjes kunnen een bron van infectie zijn. Vuil water blijft staan, wordt warm en vormt zo een uitstekende voedingsbodem voor bacteriën.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 436px; top: 419px; width: 314px; height: 90px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj147714",
	bInsAnc:	0,
	cwObj:		{
		"name":	"02-antw"
	},
	objData:	{"a":[0,0,0,[436,419,314,82]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":560,"y":419,"width":404,"height":60},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147715.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 156px; min-height: 17px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 156px; min-height: 17px;\"><p style=\"line-height: 1.5; margin-bottom: 0px; margin-top: 0px;\"><span><span style=\"font-family: arial; font-size:12pt;\"><span style=\"font-family: calibri; font-size:12pt;\">Wat moet ik doen?&nbsp;</span></span>​​​​​​​</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 436px; top: 493px; width: 156px; height: 17px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj147715",
	bInsAnc:	0,
	cwObj:		{
		"name":	"03"
	},
	objData:	{"a":[0,32,0,[436,493,156,17]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":560,"y":493,"width":200,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147716.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 314px; height: 82px; background-color: rgb(255, 255, 255);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 314px; height: 82px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">Het gebruik van lekbakjes is niet nodig bij een goede kwaliteit nippels. Gebruik je toch lekbakjes in je stal, zorg er dan voor dat ze schoon blijven.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 436px; top: 485px; width: 314px; height: 90px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj147716",
	bInsAnc:	0,
	cwObj:		{
		"name":	"03-antw"
	},
	objData:	{"a":[0,0,0,[436,485,314,82]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":560,"y":485,"width":404,"height":59},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147671.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147671",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
og147675.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147675",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
rcdObj.rcdData.att_TabletPortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_TabletPortrait = pgWidth_tabletPort;
rcdObj.preload_TabletPortrait = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/CIMG3134%2C-EM.jpg","images/P1110021-JS-knik-in-nippelleiding.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/button-act.png","images/btn-act-H.png","images/button-denk.png","images/button-denk-H.png","images/button-kijk.png","images/button-kijk-H.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_TabletPortrait = 'position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_TabletPortrait = ["#FFFFFF","",0,0,1];
