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
	objData:	{"a":[0,32,0,[-0.5000000000006253,-0.4999999999990621,785,473]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 785 35\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(392.5 17.5)\" style=\"\">\n	<path d=\"M 0 0 L 785 0 L 785 35 L 0 35 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-392.5, -17.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(392.5 17.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"12.79999968\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"4.03\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.05516e-12px; width: 785px; height: 35px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.0551559626037488e-12,785,35]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.00000000000105,783,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 19px; top: 554px; width: 26px; height: 26px; z-index: 23; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page147251.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[19,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 26px; height: 26px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 738px; top: 554px; width: 26px; height: 26px; z-index: 24; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page147355.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[738,554,26,26]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 238px; height: 5px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 238px; height: 3px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 88px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 273px; top: 571px; width: 240px; height: 5px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[273,571,240,5]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":11,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 97px; width: 703px; height: 21px; z-index: 26;",
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
	cssText:	"visibility: inherit; position: absolute; left: 8px; top: 10px; width: 22px; height: 19px; z-index: 27; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; z-index: 28;",
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
	cssText:	"visibility: inherit; position: absolute; left: 194px; top: 100px; width: 397px; height: 397px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[194,100,397,397]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
button145887.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145887Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 544px; top: 522px; width: 14px; height: 14px; z-index: 30; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj145887",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-slide-1",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og145869.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145866.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145863.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145860.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,64,0,[544,522,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":699,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
button145882.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145882Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 563px; top: 522px; width: 14px; height: 14px; z-index: 31; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj145882",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-slide-2",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og145866.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145869.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145863.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145860.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,64,0,[563,522,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":724,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
button145877.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145877Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 583px; top: 522px; width: 14px; height: 14px; z-index: 32; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj145877",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-slide-3",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og145863.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145869.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145866.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145860.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,64,0,[583,522,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":749,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
button145872.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145872Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 14px; height: 14px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 602px; top: 522px; width: 14px; height: 14px; z-index: 33; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj145872",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-slide-4",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og145860.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145869.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145866.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og145863.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,64,0,[602,522,14,14]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":774,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
og145869.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145869",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145870.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; min-height: 34px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 342px; min-height: 34px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur: goed</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Helderheid: goed&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 482px; width: 342px; height: 34px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj145870",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 4"
	},
	objData:	{"a":[0,0,0,[408,482,342,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":44},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image146314.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146314Img\" src=\"images/watertest1.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 342px; height: 257px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 150px; width: 342px; height: 257px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj146314",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest1"
	},
	objData:	{"a":[0,256,0,[408,150,342,257]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
image145871.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145871Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 14px; height: 14px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 544px; top: 522px; width: 14px; height: 14px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj145871",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[544,522,14,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":699,"y":522,"width":18,"height":18}}
};
og145866.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145866",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145867.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; min-height: 33px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 342px; min-height: 33px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur: slecht</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Helderheid: slecht&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 482px; width: 342px; height: 33px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj145867",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 2"
	},
	objData:	{"a":[0,0,0,[408,482,342,33]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":43},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image146318.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146318Img\" src=\"images/watertest5.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 342px; height: 257px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 150px; width: 342px; height: 257px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj146318",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest5"
	},
	objData:	{"a":[0,256,0,[408,150,342,257]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
image145868.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145868Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 14px; height: 14px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 563px; top: 522px; width: 14px; height: 14px; z-index: 35;",
	cssClasses:	"",
	htmlId:		"tobj145868",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[563,522,14,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":724,"y":522,"width":18,"height":18}}
};
og145863.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145863",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145864.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; min-height: 16px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 342px; min-height: 16px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur: slecht</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Helderheid: goed&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 482px; width: 342px; height: 16px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj145864",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 3"
	},
	objData:	{"a":[0,0,0,[408,482,342,16]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image146316.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146316Img\" src=\"images/watertest4.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 342px; height: 257px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 150px; width: 342px; height: 257px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj146316",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest4"
	},
	objData:	{"a":[0,256,0,[408,150,342,257]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
image145865.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145865Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 14px; height: 14px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 583px; top: 522px; width: 14px; height: 14px; z-index: 36;",
	cssClasses:	"",
	htmlId:		"tobj145865",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[583,522,14,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":749,"y":522,"width":18,"height":18}}
};
og145860.rcdData.att_TabletPortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145860",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
image145861.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj145861Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 14px; height: 14px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 602px; top: 522px; width: 14px; height: 14px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj145861",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[602,522,14,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":774,"y":522,"width":18,"height":18}}
};
image146320.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<img id=\"tobj146320Img\" src=\"images/watertest3.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 342px; height: 257px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 150px; width: 342px; height: 257px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj146320",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest3"
	},
	objData:	{"a":[0,256,0,[408,150,342,257]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
text145862.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; min-height: 16px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 342px; min-height: 16px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur en helderheid: goed</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Bezinksel: slecht&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 482px; width: 342px; height: 16px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj145862",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 4"
	},
	objData:	{"a":[0,0,0,[408,482,342,16]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text144791.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 636px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 636px; min-height: 20px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Je kunt zelf het drinkwater testen door het op 4 onderdelen te beoordelen:</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 39px; top: 127px; width: 636px; height: 20px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj144791",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[39,127,636,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":127,"width":818,"height":26},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147308.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; height: 90px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 334px; height: 90px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Kleur: </span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: totaal geen kleur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>: lichte verkleuring</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: duidelijke kleur; geel, bruin, enzovoort</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 160px; width: 342px; height: 98px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj147308",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1"
	},
	objData:	{"a":[0,0,0,[39,160,342,90]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":160,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147312.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; height: 108px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 334px; height: 108px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\"><strong>Helderheid:</strong> ​</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: geheel helder</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>: troebel, maar nog wel doorzichtig</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: ondoorzichtig</span></p><p><span>​</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 39px; top: 269px; width: 342px; height: 116px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj147312",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2"
	},
	objData:	{"a":[0,0,0,[39,269,342,108]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":269,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147316.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; height: 225px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 334px; height: 225px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Bezinksel: </span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: water bevat geen deeltjes</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>: enkele deeltjes</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: bodem is geheel bedekt met modder- of ijzerdeeltjes</span></p><p><br><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Geur:</span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: totaal geen geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>:&nbsp;lichte geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: sterke geur; ruikt naar rotte eieren</span></p><p><span style=\"font-size:12pt; color: rgb(207, 42, 39);\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 160px; width: 342px; height: 233px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj147316",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3"
	},
	objData:	{"a":[0,0,0,[408,160,342,225]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":525,"y":160,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147320.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 342px; height: 110px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 334px; height: 110px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Geur:</span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: totaal geen geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>:&nbsp;lichte geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: sterke geur; ruikt naar rotte eieren</span></p><p><span style=\"font-size:12pt; color: rgb(207, 42, 39);\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 408px; top: 269px; width: 342px; height: 118px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj147320",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4"
	},
	objData:	{"a":[0,0,0,[408,269,342,110]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":525,"y":269,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text146323.rcdData.att_TabletPortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 714px; min-height: 105px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 714px; min-height: 105px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Beoordeling:</span></strong></span></p><ul style=\"font-size:12pt;\"><li style=\"text-align:left\"><span style=\"font-family:calibri;\">Alle onderdelen zijn goed: 15% kans dat het water ongeschikt is.</span></li><li style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Alle onderdelen zijn slecht:&nbsp;</span><span style=\"font-family: calibri; font-size:12pt;\">water is altijd ongeschikt.</span><span style=\"font-family: calibri; font-size:12pt;\"> </span></li><li style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Enkele onderdelen zijn matig: 35-75% kans dat het water ongeschikt is.&nbsp;</span></li></ul></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 37px; top: 385px; width: 714px; height: 105px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj146323",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5"
	},
	objData:	{"a":[0,0,0,[37,385,714,105]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":48,"y":385,"width":918,"height":135},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_TabletPortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_TabletPortrait = pgWidth_tabletPort;
rcdObj.preload_TabletPortrait = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/btn-slide-act.png","images/btn-slide.png","images/watertest1.jpg","images/watertest4.jpg","images/watertest5.jpg","images/watertest3.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_TabletPortrait = 'position: absolute; left: 0px; top: 0px; width: 785px; height: 1000px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_TabletPortrait = ["#FFFFFF","",0,0,1];
