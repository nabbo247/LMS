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
	objData:	{"a":[0,32,0,[-0.5000000000008527,-0.499999999998721,785,473]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 785 0 L 785 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.43885e-12px; width: 785px; height: 35px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.4388490399142029e-12,785,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.000000000001435,783,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 19px; top: 554px; width: 26px; height: 26px; z-index: 28; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144812.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[19,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 26px; height: 26px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 738px; top: 554px; width: 26px; height: 26px; z-index: 29; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144817.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[738,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 238px; height: 5px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 238px; height: 3px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 120px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 273px; top: 571px; width: 240px; height: 5px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[273,571,240,5]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":15,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 97px; width: 703px; height: 21px; z-index: 31;",
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
	cssText:	"visibility: inherit; position: absolute; left: 8px; top: 10px; width: 22px; height: 19px; z-index: 32; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; z-index: 33;",
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
	cssText:	"visibility: inherit; position: absolute; left: 194px; top: 100px; width: 397px; height: 397px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[194,100,397,397]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
text144759.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 226px; min-height: 321px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 226px; min-height: 321px;\"><p><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">Producten om de waterkwaliteit te verbeteren moeten een tweeledige werking hebben: het verwijderen van de biofilm en het doden van micro-organismen. Chloorhoudende desinfectiemiddelen werken niet tegen biofilms. Sterker nog, in metalen leidingen veroorzaakt de biofilm roest, wat verergerd wordt door chloor. Te agressieve producten (zoals perazijnzuur) vreten het drinksysteem aan. Daarnaast is perazijnzuur kankerverwekkend en beïnvloedt het de smaak en geur van het drinkwater, gevolg: minder wateropname. Gebruik dus een ander reinigingsproduct.&nbsp;</span></p><p style=\"text-align:left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 125px; width: 226px; height: 321px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj144759",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[39,125,226,321]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":290,"height":412},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
shape145946.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 451 18\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(225.5 9)\" style=\"\">\n	<path d=\"M 0 0 L 451 0 L 451 18 L 0 18 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-225.5, -9) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(225.5 9)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 300px; top: 125px; width: 451px; height: 18px; z-index: 10; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145946",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[300,125.00000000000006,451,18]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":385,"y":125,"width":580,"height":23},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145946.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape145947.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 451 40\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(225.5 20)\" style=\"\">\n	<path d=\"M 0 0 L 451 0 L 451 40 L 0 40 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-225.5, -20) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(225.5 20)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 300px; top: 218px; width: 451px; height: 40px; z-index: 11; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145947",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[300,218.00000000000006,451,40]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":385,"y":218,"width":580,"height":51},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145947.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape145948.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 451 54\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(225.5 27)\" style=\"\">\n	<path d=\"M 0 0 L 451 0 L 451 54 L 0 54 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-225.5, -27) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(225.5 27)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 300px; top: 320px; width: 451px; height: 54px; z-index: 12; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145948",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[300,320.00000000000006,451,54]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":385,"y":320,"width":580,"height":70},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145948.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape145949.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 451 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(225.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 451 0 L 451 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-225.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(225.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 299px; top: 495px; width: 451px; height: 35px; z-index: 13; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145949",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[299,495.00000000000006,451,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":384,"y":495,"width":580,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145949.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og147630.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147630",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145951.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 111px; min-height: 34px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 111px; min-height: 34px;\"><p style=\"text-align:left\"><strong><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">Ozon</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 306px; top: 147px; width: 111px; height: 34px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj145951",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1"
	},
	objData:	{"a":[0,0,0,[306,147,111,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":393,"y":147,"width":143,"height":44},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145952.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 329px; min-height: 54px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 329px; min-height: 54px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Zeer effectief tegen bacteriën/virussen, reageert met ijzer en mangaan waardoor deze makkelijk verwijderd kunnen worden, inactiveert chloor, maar is zeer plaatselijk effectief.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 423px; top: 151px; width: 329px; height: 54px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj145952",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1a"
	},
	objData:	{"a":[0,0,0,[423,151,329,54]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":544,"y":151,"width":423,"height":70},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147631.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147631",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145954.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 121px; min-height: 34px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 121px; min-height: 34px;\"><p style=\"text-align:left\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Ultraviolet&nbsp;</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 306px; top: 223px; width: 121px; height: 34px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj145954",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2"
	},
	objData:	{"a":[0,0,0,[306,223,121,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":393,"y":223,"width":156,"height":44},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145955.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 327px; min-height: 33px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 327px; min-height: 33px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">Minder effectief tegen virussen, enkel effectief in dit deel van de waterleiding waar&nbsp;de UV-stralen het water raken.&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 423px; top: 223px; width: 327px; height: 33px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj145955",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2a"
	},
	objData:	{"a":[0,0,0,[423,223,327,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":544,"y":223,"width":420,"height":43},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147632.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147632",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145957.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 121px; min-height: 34px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 121px; min-height: 34px;\"><p style=\"text-align:left\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Kopersulfaat&nbsp;</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 306px; top: 275px; width: 121px; height: 34px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj145957",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3"
	},
	objData:	{"a":[0,0,0,[306,275,121,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":393,"y":275,"width":156,"height":44},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145958.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 327px; min-height: 34px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 327px; min-height: 34px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Verbindt koperionen aan de celwand van bacteriën, waardoor deze uiteindelijk afsterven.&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 423px; top: 275px; width: 327px; height: 34px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj145958",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3a"
	},
	objData:	{"a":[0,0,0,[423,275,327,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":544,"y":275,"width":420,"height":44},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147633.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147633",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145960.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 119px; min-height: 32px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 119px; min-height: 32px;\"><p style=\"text-align:left\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Chloor&nbsp;</span><span style=\"font-family: calibri; font-size:12pt;\">&nbsp;</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 306px; top: 325px; width: 119px; height: 32px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj145960",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4"
	},
	objData:	{"a":[0,0,0,[306,325,119,32]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":393,"y":325,"width":153,"height":41},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145961.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 327px; min-height: 51px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 327px; min-height: 51px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Goedkoop, maar minder effectief bij een pH hoger dan 7 of bij aanwezigheid van organisch materiaal. In dat geval kun je azijn toevoegen.</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 422px; top: 325px; width: 327px; height: 51px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj145961",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4a"
	},
	objData:	{"a":[0,0,0,[422,325,327,51]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":543,"y":325,"width":420,"height":66},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147634.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147634",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145963.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 116px; min-height: 30px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 116px; min-height: 30px;\"><p style=\"text-align:left\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Organische zuren&nbsp;</span><span style=\"font-family: calibri; font-size:12pt;\">&nbsp;</span></strong></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 306px; top: 400px; width: 116px; height: 30px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj145963",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5"
	},
	objData:	{"a":[0,0,0,[306,400,116,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":393,"y":400,"width":149,"height":38},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145964.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 327px; min-height: 66px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 327px; min-height: 66px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Bacterieremmend. De pH van het drinkwater moet na toevoeging dalen tot lager dan 4,3 omdat anders volop schimmels en gisten gaan groeien in de drinklijnen (pH tot 4 heeft geen negatieve invloed op de wateropname).&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 423px; top: 400px; width: 327px; height: 66px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj145964",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5a"
	},
	objData:	{"a":[0,0,0,[423,400,327,66]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":544,"y":400,"width":420,"height":85},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147635.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147635",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145966.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 111px; min-height: 30px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 111px; min-height: 30px;\"><p style=\"text-align:left\"><span><strong><span><span style=\"font-family: calibri; font-size:12pt;\">Waterstof</span><span style=\"font-family: calibri; font-size:12pt;\">peroxide&nbsp;</span></span></strong></span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 306px; top: 497px; width: 111px; height: 30px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj145966",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6"
	},
	objData:	{"a":[0,0,0,[306,497,111,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":393,"y":497,"width":143,"height":39},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145967.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 327px; min-height: 32px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 327px; min-height: 32px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Efficiënte reiniging van de drinklijnen waarbij schimmels en bacteriën gedood worden en de biofilm opgelost wordt.&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 422px; top: 497px; width: 327px; height: 32px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj145967",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6a"
	},
	objData:	{"a":[0,0,0,[422,497,327,32]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":542,"y":497,"width":420,"height":41},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145972.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 129px; min-height: 17px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 129px; min-height: 17px;\"><p style=\"text-align:left\"><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\"><strong>Middelen</strong>&nbsp;</span></p><p><span style=\"color: rgb(255, 255, 255);\">&nbsp;</span></p><p><span style=\"color: rgb(255, 255, 255);\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 306px; top: 126px; width: 129px; height: 17px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj145972",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[306,126,129,17]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":393,"y":126,"width":166,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145973.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 303px; min-height: 16px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 303px; min-height: 16px;\"><p style=\"text-align:left\"><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\"><strong>Werking</strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 423px; top: 126px; width: 303px; height: 16px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj145973",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 2"
	},
	objData:	{"a":[0,32,0,[423,126,303,16]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":544,"y":126,"width":389,"height":21},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_TabletPortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_TabletPortrait = pgWidth_tabletPort;
rcdObj.preload_TabletPortrait = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_TabletPortrait = 'position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_TabletPortrait = ["#FFFFFF","",0,0,1];
