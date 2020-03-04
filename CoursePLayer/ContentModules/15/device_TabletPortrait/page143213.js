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
	objData:	{"a":[0,32,0,[-0.5000000000014211,-0.49999999999786837,785,473]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 785 0 L 785 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 2.39808e-12px; width: 785px; height: 35px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,2.398081733190338e-12,785,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.0000000000024,783,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 19px; top: 554px; width: 26px; height: 26px; z-index: 35; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144827.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[19,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 26px; height: 26px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 738px; top: 554px; width: 26px; height: 26px; z-index: 36; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144833.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[738,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 238px; height: 5px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 238px; height: 3px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 200px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 273px; top: 571px; width: 240px; height: 5px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[273,571,240,5]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":25,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 97px; width: 703px; height: 21px; z-index: 38;",
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
	cssText:	"visibility: inherit; position: absolute; left: 8px; top: 10px; width: 22px; height: 19px; z-index: 39; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; z-index: 40;",
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
	cssText:	"visibility: inherit; position: absolute; left: 194px; top: 100px; width: 397px; height: 397px; z-index: 41;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[194,100,397,397]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
text143214.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 696px; min-height: 93px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 696px; min-height: 93px;\"><p style=\"text-align:left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">De belangrijkste eigenschappen voor strooisel zijn het vochtabsorberend vermogen en de afwezigheid van stof. Tussen partijen van eenzelfde type strooisel zit veel verschil.&nbsp;De kostprijs, beschikbaarheid en manier waarop de&nbsp;pluimveemest&nbsp;wordt&nbsp;verwerkt bepaalt de strooiselkeuze.&nbsp;Gebruik geen zaagsel of houtkrullen afkomstig van afvalhout (oude meubelen of resten verduurzaamd hout): de hierin aanwezige chemische stoffen kunnen giftig zijn voor de kuikens, en voor de mens (residuen).&nbsp;</span></p><p><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 125px; width: 696px; height: 93px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj143214",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[39,125,696,93]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":895,"height":120},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button147770.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147770Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 80px; top: 833px; width: 14px; height: 14px; z-index: 42; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147770",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-lees-3 neus",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ button147770.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ button147770.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:0,delay:0,name:'OnMEnterShow',actItem:function(){ og147764.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og147764.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[5,6496,0,[80,833,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":906,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147780.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147780Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 183px; top: 833px; width: 14px; height: 14px; z-index: 43; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147780",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-lees-3 neus",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ button147780.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ button147780.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:0,delay:0,name:'OnMEnterShow',actItem:function(){ og147765.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og147765.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[5,6496,0,[183,833,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":774,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147788.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147788Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 286px; top: 833px; width: 14px; height: 14px; z-index: 44; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147788",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-lees-3 neus",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ button147788.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ button147788.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:0,delay:0,name:'OnMEnterShow',actItem:function(){ og147766.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og147766.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[5,6496,0,[286,833,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":642,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147796.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147796Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 385px; top: 833px; width: 14px; height: 14px; z-index: 45; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147796",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-lees-3 neus",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ button147796.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ button147796.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:0,delay:0,name:'OnMEnterShow',actItem:function(){ og147768.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og147768.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[5,6496,0,[385,833,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":514,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147804.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147804Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 489px; top: 833px; width: 14px; height: 14px; z-index: 46; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147804",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-lees-3 neus",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ button147804.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ button147804.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:0,delay:0,name:'OnMEnterShow',actItem:function(){ og147767.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og147767.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[5,6496,0,[489,833,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":380,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147820.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147820Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 587px; top: 833px; width: 14px; height: 14px; z-index: 47; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147820",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-lees-3 neus",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ button147820.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ button147820.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:0,delay:0,name:'OnMEnterShow',actItem:function(){ og147769.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og147769.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[5,6496,0,[587,833,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":254,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147829.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj147829Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 690px; top: 833px; width: 14px; height: 14px; z-index: 48; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj147829",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-lees-3 neus",
		"arChld":
	[
		{type:6,on:0,delay:0,name:'OnMEnterHide',actItem:function(){ button147829.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ button147829.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:0,delay:0,name:'OnMEnterShow',actItem:function(){ og147779.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og147779.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[5,6496,0,[690,833,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":122,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
image146428.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146428Img\" src=\"images/strooisel-tabel.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 710px; height: 189px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 217px; width: 710px; height: 189px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj146428",
	bInsAnc:	0,
	cwObj:		{
		"name":	"strooisel-tabel"
	},
	objData:	{"a":[0,288,0,[39,217,710,189]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":217,"width":912,"height":243}}
};
og147764.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147764",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146456.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 391px; width: 100px; height: 19px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj146456",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1a"
	},
	objData:	{"a":[0,0,0,[39,391,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146457.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 436px; width: 100px; height: 19px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj146457",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1b"
	},
	objData:	{"a":[0,0,0,[39,436,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147765.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147765",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146462.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 140px; top: 391px; width: 100px; height: 19px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj146462",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2a"
	},
	objData:	{"a":[0,0,0,[140,391,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":180,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146461.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 140px; top: 436px; width: 100px; height: 19px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj146461",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2b"
	},
	objData:	{"a":[0,0,0,[140,436,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":180,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147766.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147766",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146466.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 241px; top: 391px; width: 100px; height: 19px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj146466",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3a"
	},
	objData:	{"a":[0,0,0,[241,391,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":310,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146467.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 241px; top: 436px; width: 100px; height: 19px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj146467",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3b"
	},
	objData:	{"a":[0,0,0,[241,436,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":310,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147768.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147768",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146475.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 342px; top: 391px; width: 100px; height: 19px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj146475",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4a"
	},
	objData:	{"a":[0,0,0,[342,391,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":440,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146474.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align:center\"><span style=\"font-family:\'Arial\',sans-serif;font-size:12pt;color:0\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 342px; top: 436px; width: 100px; height: 19px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj146474",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4b"
	},
	objData:	{"a":[0,0,0,[342,436,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":440,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147767.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147767",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146479.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 31px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 31px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p><p style=\"text-align: center;\"><span>&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 443px; top: 391px; width: 100px; height: 31px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj146479",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5a"
	},
	objData:	{"a":[0,0,0,[443,391,100,31]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":570,"y":391,"width":129,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146480.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 443px; top: 436px; width: 100px; height: 19px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj146480",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5b"
	},
	objData:	{"a":[0,0,0,[443,436,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":570,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147769.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147769",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146485.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align:center\"><span style=\"font-family:\'Arial\',sans-serif;font-size:12pt;color:0\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 545px; top: 391px; width: 100px; height: 19px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj146485",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6a"
	},
	objData:	{"a":[0,0,0,[545,391,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":700,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146484.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 545px; top: 436px; width: 100px; height: 19px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj146484",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6b"
	},
	objData:	{"a":[0,0,0,[545,436,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":700,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147779.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147779",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146489.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 647px; top: 391px; width: 100px; height: 19px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj146489",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7a"
	},
	objData:	{"a":[0,0,0,[647,391,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":831,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146490.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 100px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 100px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 647px; top: 436px; width: 100px; height: 19px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj146490",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7b"
	},
	objData:	{"a":[0,0,0,[647,436,100,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":831,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146424.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 709px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 709px; min-height: 19px;\"><p style=\"text-align: center;\"><strong><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">&nbsp;Vochtabsorberend vermogen&nbsp;+ = goed, absorberend vermogen</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 369px; width: 709px; height: 19px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj146424",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 5"
	},
	objData:	{"a":[0,32,0,[39,369,709,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":369,"width":911,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146430.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 710px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 710px; min-height: 19px;\"><p style=\"text-align: center;\"><strong><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">Gehalte stofdeeltjes&nbsp;+ = goed, weinig stof</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 413px; width: 710px; height: 19px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj146430",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 6"
	},
	objData:	{"a":[0,32,0,[39,413,710,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":413,"width":912,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145563.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Gehakseld stro</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 44px; top: 334px; width: 89px; height: 23px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj145563",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[44,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":57,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146431.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Tarwestro</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 144px; top: 334px; width: 89px; height: 23px; z-index: 28;",
	cssClasses:	"",
	htmlId:		"tobj146431",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[144,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":185,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146435.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Houtkrullen</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 246px; top: 334px; width: 89px; height: 23px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj146435",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[246,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":316,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146439.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Zaagsel</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 347px; top: 334px; width: 89px; height: 23px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj146439",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[347,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":446,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146443.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Gehakseld vlas</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 448px; top: 334px; width: 89px; height: 23px; z-index: 31;",
	cssClasses:	"",
	htmlId:		"tobj146443",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[448,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":576,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146447.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 89px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 89px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Rijstkaf</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 549px; top: 334px; width: 89px; height: 23px; z-index: 32;",
	cssClasses:	"",
	htmlId:		"tobj146447",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[549,334,89,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":706,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146451.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 96px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 96px; min-height: 23px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Zonnebloemhulzen</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 649px; top: 334px; width: 96px; height: 23px; z-index: 33;",
	cssClasses:	"",
	htmlId:		"tobj146451",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[649,334,96,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":834,"y":334,"width":124,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146757.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 443px; min-height: 78px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 443px; min-height: 78px;\"><p style=\"text-align:left\"><span><strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\">Voorbeelden van strooiseltypes</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 45px; top: 220px; width: 443px; height: 78px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj146757",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[45,220,443,78]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":58,"y":220,"width":570,"height":100},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_TabletPortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_TabletPortrait = pgWidth_tabletPort;
rcdObj.preload_TabletPortrait = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/btn-lees-hover.png","images/strooisel-tabel.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-lees147762.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_TabletPortrait = 'position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_TabletPortrait = ["#FFFFFF","",0,0,1];
