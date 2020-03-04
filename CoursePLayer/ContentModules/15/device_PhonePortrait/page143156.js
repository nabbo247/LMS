if (window.VarCurrentView) VarCurrentView.set('PhonePortrait');
function init_PhonePortrait() {
	if ( rcdObj.view != 'PhonePortrait' ) return;
	if (!isOPAPub() || isLOPopup()) window.init_page();
	preload(rcdObj['preload_'+rcdObj.view]);
}
function defineFuncs_PhonePortrait() {
	if ( rcdObj.view != 'PhonePortrait' ) return;
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
og148932.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148932",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
og28117.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og28117",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape146877.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 481 290\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(240.5 145)\" style=\"\">\n	<path d=\"M 0 0 L 480 0 L 480 289 L 0 289 L 0 0 Z\" style=\"stroke: rgb(219, 102, 39); stroke-width: 1; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-240, -144.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(240.5 145)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"8.016666466250001\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"2.53\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: -0.5px; top: -0.5px; width: 481px; height: 290px; z-index: 1; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj146877",
	bInsAnc:	0,
	cwObj:		{
		"name":	"kaderlijn"
	},
	objData:	{"a":[0,32,0,[-0.5000000000005684,-0.49999999999886313,481,290]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 480 21\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(240 10.5)\" style=\"\">\n	<path d=\"M 0 0 L 480 0 L 480 21 L 0 21 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-240, -10.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(240 10.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"7.9999998\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"2.52\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.1724e-12px; width: 480px; height: 21px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.1723955140041653e-12,480,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137498.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 479 16\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(239.5 8)\" style=\"\">\n	<path d=\"M 0 0 L 479 0 L 479 16 L 0 16 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-239.5, -8) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(239.5 8)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"7.9999998\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"2.52\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 45px; width: 479px; height: 16px; z-index: 3; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137498",
	bInsAnc:	0,
	cwObj:		{
		"name":	"subheaderbackground"
	},
	objData:	{"a":[0,160,0,[0,45.00000000000117,479,16]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
button146730.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146730Img\" src=\"images/btn-close143187.png\" style=\"position: absolute; left: 0px; top: 0px; width: 10px; height: 10px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 464px; top: 14px; width: 10px; height: 10px; z-index: 4; cursor: pointer;",
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
	objData:	{"a":[4,288,0,[464,14,10,10]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":975,"y":14,"width":20,"height":20},"res":"images/btn-close143187.png","resClick":"images/btn-close143187.png","resOver":"images/btn-close-hover143188.png"}
};
image147010.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147010Img\" src=\"images/logo-roodbont.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 64px; height: 10px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 405px; top: 52px; width: 64px; height: 10px; z-index: 5;",
	cssClasses:	"",
	htmlId:		"tobj147010",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-roodbont"
	},
	objData:	{"a":[0,256,0,[405,52,64,10]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":852,"y":52,"width":135,"height":21}}
};
image148817.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj148817Img\" src=\"images/logo-Aeres.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 67px; height: 29px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 393px; top: 9px; width: 67px; height: 29px; z-index: 6;",
	cssClasses:	"",
	htmlId:		"tobj148817",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-Aeres"
	},
	objData:	{"a":[0,288,0,[393,9,67,29]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":826,"y":9,"width":140,"height":61}}
};
button352.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj352Img\" src=\"images/prev.png\" style=\"position: absolute; left: 0px; top: 0px; width: 16px; height: 16px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 12px; top: 554px; width: 16px; height: 16px; z-index: 19; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page137673.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[12,554,16,16]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 16px; height: 16px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 451px; top: 554px; width: 16px; height: 16px; z-index: 20; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page148387.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[451,554,16,16]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 145px; height: 3px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 145px; height: 1px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 98px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 167px; top: 571px; width: 147px; height: 3px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[167,571,147,3]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":20,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
};
text354.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 409px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 409px; min-height: 19px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span><strong><span style=\"font-size:22pt; color: rgb(255, 255, 255); font-family: calibri;\">Vleeskuikensignalen -&nbsp;</span></strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:22pt;\">Water en strooisel</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 5px; width: 409px; height: 19px; z-index: 7;",
	cssClasses:	"",
	htmlId:		"tobj354",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Title module"
	},
	objData:	{"a":[0,32,0,[24,5,409,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":5,"width":860,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146550.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 428px; min-height: 16px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 428px; min-height: 16px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span style=\"font-size:18pt; color: rgb(102, 102, 102); font-family: calibri;\">Title of chapter</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 47px; width: 428px; height: 16px; z-index: 8;",
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
	objData:	{"a":[0,32,0,[24,47,428,16]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":47,"width":900,"height":34},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146548.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 430px; min-height: 13px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 430px; min-height: 13px;\"><p leglh=\"1.218\" style=\"margin-left:0px;text-indent:0px;line-height:1.218;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span style=\"font-size:14pt; font-family: calibri;\"><strong><span style=\"color: rgb(0, 0, 0);\">Title of Page</span></strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000; \"><strong> </strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000;\"> </span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 97px; width: 430px; height: 13px; z-index: 22;",
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
	objData:	{"a":[0,96,0,[24,97,430,13]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":97,"width":903,"height":27},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148245.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj148245Img\" src=\"images/btn-home.png\" style=\"position: absolute; left: 0px; top: 0px; width: 38px; height: 32px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 20px; top: 8px; width: 38px; height: 32px; z-index: 23; cursor: pointer;",
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
	objData:	{"a":[4,352,0,[20,8,38,32]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":10,"y":10,"width":28,"height":25},"res":"images/btn-home.png","resClick":"images/btn-home.png","resOver":"images/btn-home-H.png"}
};
og148948.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og148948",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape148949.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj148949Img\" src=\"images/shape9278.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 480px; height: 763px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 480px; height: 763px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj148949",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,16480,0,[0,0,480,763]],"rcdOvr":{"res":2},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1047,"y":0,"width":1009,"height":608}}
};
image148950.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj148950Img\" src=\"images/rotate-mobile.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 302px; height: 302px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 90px; top: 142px; width: 302px; height: 302px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[90,142,302,302]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
button146066.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146066Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 8px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 343px; top: 483px; width: 9px; height: 8px; z-index: 9; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146066",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-slide-1",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og146059.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og146055.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ shape146401.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,288,0,[343,483,9,8]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":720,"y":483,"width":18,"height":17},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
button146063.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146063Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 8px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 357px; top: 483px; width: 9px; height: 8px; z-index: 10; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj146063",
	bInsAnc:	1,
	cwObj:		{
		"name":	"btn-slide-2",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkShow',actItem:function(){ og146055.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og146059.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:2,delay:0,name:'OnMClkHide',actItem:function(){ og146521.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,288,0,[357,483,9,8]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":751,"y":483,"width":18,"height":17},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
og146059.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og146059",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
image146060.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146060Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 9px; height: 9px;\">",
	cssText:	"left: 343px; top: 483px; visibility: hidden; position: absolute; width: 9px; height: 9px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj146060",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[32,352,[35,0,3,0,0,0],[343,483,9,9]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":720,"y":483,"width":18,"height":18}}
};
image146391.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146391Img\" src=\"images/4-GP-house-geen-scaduw-en-watertoren-warm-KvM.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 209px; height: 139px;\">",
	cssText:	"left: 249px; top: 125px; visibility: hidden; position: absolute; width: 209px; height: 139px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj146391",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4-GP-house-geen-scaduw-en-watertoren-warm-KvM",
		"arChld":
	[
		{type:6,on:5,delay:0,name:'OnShowShow',actItem:function(){ og146521.show(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:5,delay:0,name:'OnShowHide',actItem:function(){ shape146401.hide(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[32,288,[35,0,3,0,0,0],[249,125,209,139]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":125,"width":440,"height":293}}
};
text146061.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 209px; min-height: 26px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 209px; min-height: 26px;\"><p leglh=\"1.127\" style=\"margin-left:0px;text-indent:0px;line-height:1.080;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Deze watertank wordt de hele dag verwarmd door de zon, omdat hij hoog staat (in verband met waterdruk). Het water zal warm zijn als het de stal binnenkomt.&nbsp;</span></em><em><span style=\" font-size:12pt; font-family:\'Calibri\', sans-serif; color:#22272b; \"> </span></em></span></p></div></div>",
	cssText:	"left: 249px; top: 422px; visibility: hidden; position: absolute; width: 209px; height: 26px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj146061",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 2"
	},
	objData:	{"a":[32,32,[35,0,3,0,0,0],[249,422,209,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":422,"width":440,"height":54},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og146055.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og146055",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
image146056.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146056Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 9px; height: 9px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 357px; top: 483px; width: 9px; height: 9px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj146056",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[32,320,[35,0,3,0,0,0],[357,483,9,9]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":751,"y":483,"width":18,"height":18}}
};
image146393.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146393Img\" src=\"images/_DSC4443%2C.-watertank-afdak-PTCplus.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 209px; height: 139px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 249px; top: 125px; width: 209px; height: 139px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj146393",
	bInsAnc:	0,
	cwObj:		{
		"name":	"_DSC4443,.-watertank-afdak-PTCplus",
		"arChld":
	[
		{type:6,on:5,delay:0,name:'OnShowHide',actItem:function(){ og146521.hide(); 
    if(typeof pF == 'function') pF(); }},
		{type:6,on:5,delay:0,name:'OnShowShow',actItem:function(){ shape146401.show(); 
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[32,256,[35,0,3,0,0,0],[249,125,209,139]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":125,"width":440,"height":293}}
};
text146058.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 209px; min-height: 29px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 209px; min-height: 29px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Een afdakje voorkomt direct zonlicht en daarmee het opwarmen van het water.&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 249px; top: 422px; width: 209px; height: 29px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj146058",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Bijschrift 2"
	},
	objData:	{"a":[32,0,[35,0,3,0,0,0],[249,422,209,29]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":422,"width":440,"height":61},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text143157.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 209px; min-height: 181px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 209px; min-height: 181px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Ondersteun de kuikens bij hoge temperatuur door te zorgen dat het water koel is: </span></p><ol style=\"padding-left: 34px; -webkit-padding-start: 34px;\"><li style=\"font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span id=\"trivUnsetLiStyle\" style=\"font-weight: normal; font-style: normal; color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Zorg dat de wateropslag niet in de volle zon staat en goed&nbsp;geïsoleerd is.</span></li><li style=\"font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span id=\"trivUnsetLiStyle\" style=\"font-weight: normal; font-style: normal; color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Zorg dat de leidingen niet in de zon zijn geplaatst (bij voorkeur ondergronds).</span></li><li style=\"font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span id=\"trivUnsetLiStyle\" style=\"font-weight: normal; font-style: normal; color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Zorg dat het water ook aan het einde van de drinklijn rustig blijft doorstromen.</span></li><li style=\"font-family: calibri, sans-serif; font-size:12pt; color: rgb(0, 0, 0); font-weight: normal; font-style: normal;\"><span id=\"trivUnsetLiStyle\" style=\"font-weight: normal; font-style: normal; color: rgb(0, 0, 0); font-family: calibri; font-size:12pt;\">Doe ijsblokken in de watertank als de temperatuur te hoog is.&nbsp;</span></li></ol></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 125px; width: 209px; height: 181px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj143157",
	bInsAnc:	0,
	cwObj:		{
		"name":	"header"
	},
	objData:	{"a":[0,32,0,[24,125,209,181]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":440,"height":381},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
shape146401.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 212 142\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(106 71)\" style=\"\">\n	<path d=\"M 0 0 L 209 0 L 209 139 L 0 139 L 0 0 Z\" style=\"stroke: rgb(106, 168, 79); stroke-width: 3; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(255, 255, 255); fill-opacity:0;filter:alpha(opacity=0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-104.5, -69.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(106 71)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"8.114832333014354\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"2.56\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 247.5px; top: 123.5px; width: 212px; height: 142px; z-index: 16; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj146401",
	bInsAnc:	0,
	cwObj:		{
		"name":	"goed"
	},
	objData:	{"a":[32,0,[7,0,8,0,0,0],[247.5,123.50000000000003,212,142]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":125,"width":443,"height":296},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146401.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
og146521.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og146521",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
shape146522.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 211 142\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(105.5 71)\" style=\"\">\n	<path d=\"M 0 0 L 207 138\" style=\"stroke: rgb(207, 42, 39); stroke-width: 4; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(207, 42, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-103.5, -69) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(105.5 71)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"8.154589168115944\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"2.57\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 249px; top: 123px; width: 211px; height: 142px; z-index: 17; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj146522",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Line"
	},
	objData:	{"a":[32,0,[1,0,4,0,0,0],[249,123.00000000000003,211,142]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":527,"y":125,"width":440,"height":295},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146522.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape146523.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 212 142\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(106 71)\" style=\"\">\n	<path d=\"M 0 0 L 208 138\" style=\"stroke: rgb(207, 42, 39); stroke-width: 4; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(207, 42, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-104, -69) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(106 71) matrix(-1 0 0 1 0 0) \">\n		<text font-family=\"Arial,sans-serif\" font-size=\"8.15384595\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"2.57\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: hidden; position: absolute; left: 248px; top: 123px; width: 212px; height: 142px; z-index: 18; transform: scaleX(-1); overflow: visible; pointer-events: none;; behavior:url(-ms-transform.htc); -moz-transform: ScaleX(-1); -webkit-transform: ScaleX(-1); -o-transform: ScaleX(-1); -ms-transform: ScaleX(-1); filter: fliph; -ms-filter: fliph",
	cssClasses:	"",
	htmlId:		"tobj146523",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Line 2"
	},
	objData:	{"a":[32,0,[1,0,4,0,0,0],[248,123.00000000000003,212,142]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":525,"y":125,"width":441,"height":294},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146523.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
rcdObj.rcdData.att_PhonePortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_PhonePortrait = pgWidth_phonePort;
rcdObj.preload_PhonePortrait = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/btn-slide-act.png","images/btn-slide.png","images/4-GP-house-geen-scaduw-en-watertoren-warm-KvM.jpg","images/_DSC4443%2C.-watertank-afdak-PTCplus.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_PhonePortrait = 'position: absolute; left: 0px; top: 0px; width: 480px; height: 763px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_PhonePortrait = ["#FFFFFF","",0,0,1];
