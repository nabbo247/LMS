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
	objData:	{"a":[0,32,0,[-0.5000000000007105,-0.4999999999985789,481,290]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<svg viewBox=\"0 0 480 21\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(240 10.5)\" style=\"\">\n	<path d=\"M 0 0 L 480 0 L 480 21 L 0 21 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-240, -10.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(240 10.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"7.9999998\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"2.52\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.46549e-12px; width: 480px; height: 21px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.4654943925052066e-12,480,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[0,45.000000000001464,479,16]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 12px; top: 554px; width: 16px; height: 16px; z-index: 35; cursor: pointer;",
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
	objData:	{"a":[4,352,0,[12,554,16,16]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 16px; height: 16px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 451px; top: 554px; width: 16px; height: 16px; z-index: 36; cursor: pointer;",
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
	objData:	{"a":[4,352,0,[451,554,16,16]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 145px; height: 3px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 145px; height: 1px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 123px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 167px; top: 571px; width: 147px; height: 3px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[167,571,147,3]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":25,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 97px; width: 430px; height: 13px; z-index: 38;",
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
	cssText:	"visibility: inherit; position: absolute; left: 20px; top: 8px; width: 38px; height: 32px; z-index: 39; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 0px; width: 480px; height: 763px; z-index: 40;",
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
	cssText:	"visibility: inherit; position: absolute; left: 90px; top: 142px; width: 302px; height: 302px; z-index: 41;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[90,142,302,302]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
text143214.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 426px; min-height: 57px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 426px; min-height: 57px;\"><p style=\"text-align:left\"><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">De belangrijkste eigenschappen voor strooisel zijn het vochtabsorberend vermogen en de afwezigheid van stof. Tussen partijen van eenzelfde type strooisel zit veel verschil.&nbsp;De kostprijs, beschikbaarheid en manier waarop de&nbsp;pluimveemest&nbsp;wordt&nbsp;verwerkt bepaalt de strooiselkeuze.&nbsp;Gebruik geen zaagsel of houtkrullen afkomstig van afvalhout (oude meubelen of resten verduurzaamd hout): de hierin aanwezige chemische stoffen kunnen giftig zijn voor de kuikens, en voor de mens (residuen).&nbsp;</span></p><p><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 125px; width: 426px; height: 57px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj143214",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[24,125,426,57]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":895,"height":120},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button147770.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147770Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 9px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 49px; top: 661px; width: 9px; height: 9px; z-index: 42; cursor: pointer;",
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
	objData:	{"a":[5,6496,0,[49,661,9,9]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":906,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147780.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147780Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 9px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 112px; top: 661px; width: 9px; height: 9px; z-index: 43; cursor: pointer;",
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
	objData:	{"a":[5,6496,0,[112,661,9,9]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":774,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147788.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147788Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 9px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 175px; top: 661px; width: 9px; height: 9px; z-index: 44; cursor: pointer;",
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
	objData:	{"a":[5,6496,0,[175,661,9,9]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":642,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147796.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147796Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 9px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 235px; top: 661px; width: 9px; height: 9px; z-index: 45; cursor: pointer;",
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
	objData:	{"a":[5,6496,0,[235,661,9,9]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":514,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147804.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147804Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 9px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 299px; top: 661px; width: 9px; height: 9px; z-index: 46; cursor: pointer;",
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
	objData:	{"a":[5,6496,0,[299,661,9,9]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":380,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147820.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147820Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 9px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 359px; top: 661px; width: 9px; height: 9px; z-index: 47; cursor: pointer;",
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
	objData:	{"a":[5,6496,0,[359,661,9,9]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":254,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
button147829.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj147829Img\" src=\"images/btn-lees147762.png\" style=\"position: absolute; left: 0px; top: 0px; width: 9px; height: 9px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 422px; top: 661px; width: 9px; height: 9px; z-index: 48; cursor: pointer;",
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
	objData:	{"a":[5,6496,0,[422,661,9,9]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":122,"y":215,"width":18,"height":18},"res":"images/btn-lees147762.png","resClick":"images/btn-lees-hover.png","resOver":"images/btn-lees-hover.png"}
};
image146428.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<img id=\"tobj146428Img\" src=\"images/strooisel-tabel.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 434px; height: 116px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 217px; width: 434px; height: 116px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj146428",
	bInsAnc:	0,
	cwObj:		{
		"name":	"strooisel-tabel"
	},
	objData:	{"a":[0,288,0,[24,217,434,116]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":217,"width":912,"height":243}}
};
og147764.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147764",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146456.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 24px; top: 391px; width: 61px; height: 11px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj146456",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1a"
	},
	objData:	{"a":[0,0,0,[24,391,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146457.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 24px; top: 436px; width: 61px; height: 11px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj146457",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1b"
	},
	objData:	{"a":[0,0,0,[24,436,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147765.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147765",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146462.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 86px; top: 391px; width: 61px; height: 11px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj146462",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2a"
	},
	objData:	{"a":[0,0,0,[86,391,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":180,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146461.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 86px; top: 436px; width: 61px; height: 11px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj146461",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2b"
	},
	objData:	{"a":[0,0,0,[86,436,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":180,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147766.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147766",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146466.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 147px; top: 391px; width: 61px; height: 11px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj146466",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3a"
	},
	objData:	{"a":[0,0,0,[147,391,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":310,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146467.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 147px; top: 436px; width: 61px; height: 11px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj146467",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3b"
	},
	objData:	{"a":[0,0,0,[147,436,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":310,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147768.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147768",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146475.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 209px; top: 391px; width: 61px; height: 11px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj146475",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4a"
	},
	objData:	{"a":[0,0,0,[209,391,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":440,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146474.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align:center\"><span style=\"font-family:\'Arial\',sans-serif;font-size:12pt;color:0\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 209px; top: 436px; width: 61px; height: 11px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj146474",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4b"
	},
	objData:	{"a":[0,0,0,[209,436,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":440,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147767.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147767",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146479.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 19px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 19px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+</span></p><p style=\"text-align: center;\"><span>&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 271px; top: 391px; width: 61px; height: 19px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj146479",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5a"
	},
	objData:	{"a":[0,0,0,[271,391,61,19]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":570,"y":391,"width":129,"height":40},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146480.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 271px; top: 436px; width: 61px; height: 11px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj146480",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5b"
	},
	objData:	{"a":[0,0,0,[271,436,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":570,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147769.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147769",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146485.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align:center\"><span style=\"font-family:\'Arial\',sans-serif;font-size:12pt;color:0\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 333px; top: 391px; width: 61px; height: 11px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj146485",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6a"
	},
	objData:	{"a":[0,0,0,[333,391,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":700,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146484.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 333px; top: 436px; width: 61px; height: 11px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj146484",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6b"
	},
	objData:	{"a":[0,0,0,[333,436,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":700,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147779.rcdData.att_PhonePortrait = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147779",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
text146489.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">-</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 395px; top: 391px; width: 61px; height: 11px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj146489",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7a"
	},
	objData:	{"a":[0,0,0,[395,391,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":831,"y":391,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146490.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 61px; min-height: 11px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 61px; min-height: 11px;\"><p style=\"text-align: center;\"><span style=\"font-family: Arial, sans-serif; font-size:12pt;\">+++</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 395px; top: 436px; width: 61px; height: 11px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj146490",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7b"
	},
	objData:	{"a":[0,0,0,[395,436,61,11]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":831,"y":436,"width":129,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146424.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 433px; min-height: 12px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 433px; min-height: 12px;\"><p style=\"text-align: center;\"><strong><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">&nbsp;Vochtabsorberend vermogen&nbsp;+ = goed, absorberend vermogen</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 369px; width: 433px; height: 12px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj146424",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 5"
	},
	objData:	{"a":[0,32,0,[24,369,433,12]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":369,"width":911,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146430.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 434px; min-height: 12px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 434px; min-height: 12px;\"><p style=\"text-align: center;\"><strong><span style=\"color:#000000;font-family:calibri;font-size:12pt;\">Gehalte stofdeeltjes&nbsp;+ = goed, weinig stof</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 24px; top: 413px; width: 434px; height: 12px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj146430",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 6"
	},
	objData:	{"a":[0,32,0,[24,413,434,12]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":413,"width":912,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145563.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 55px; min-height: 14px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 55px; min-height: 14px;\"><p style=\"text-align: center;\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Gehakseld stro</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 27px; top: 334px; width: 55px; height: 14px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj145563",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[27,334,55,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":57,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146431.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 55px; min-height: 14px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 55px; min-height: 14px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Tarwestro</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 88px; top: 334px; width: 55px; height: 14px; z-index: 28;",
	cssClasses:	"",
	htmlId:		"tobj146431",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[88,334,55,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":185,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146435.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 55px; min-height: 14px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 55px; min-height: 14px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Houtkrullen</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 150px; top: 334px; width: 55px; height: 14px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj146435",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[150,334,55,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":316,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146439.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 55px; min-height: 14px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 55px; min-height: 14px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Zaagsel</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 212px; top: 334px; width: 55px; height: 14px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj146439",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[212,334,55,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":446,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146443.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 55px; min-height: 14px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 55px; min-height: 14px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Gehakseld vlas</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 274px; top: 334px; width: 55px; height: 14px; z-index: 31;",
	cssClasses:	"",
	htmlId:		"tobj146443",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[274,334,55,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":576,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146447.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 55px; min-height: 14px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 55px; min-height: 14px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Rijstkaf</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 336px; top: 334px; width: 55px; height: 14px; z-index: 32;",
	cssClasses:	"",
	htmlId:		"tobj146447",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[336,334,55,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":706,"y":334,"width":115,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146451.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 59px; min-height: 14px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 59px; min-height: 14px;\"><p style=\"text-align: center;\"><strong><span style=\"font-family: calibri; font-size:12pt;\">Zonnebloemhulzen</span></strong></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 397px; top: 334px; width: 59px; height: 14px; z-index: 33;",
	cssClasses:	"",
	htmlId:		"tobj146451",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[397,334,59,14]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":834,"y":334,"width":124,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146757.rcdData.att_PhonePortrait = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 271px; min-height: 48px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 271px; min-height: 48px;\"><p style=\"text-align:left\"><span><strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\">Voorbeelden van strooiseltypes</span></strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 28px; top: 220px; width: 271px; height: 48px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj146757",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[28,220,271,48]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":58,"y":220,"width":570,"height":100},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_PhonePortrait = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	31
};
rcdObj.pgWidth_PhonePortrait = pgWidth_phonePort;
rcdObj.preload_PhonePortrait = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/btn-lees-hover.png","images/strooisel-tabel.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-lees147762.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png","images/shape3918161.png","images/rotate-mobile.png"];
rcdObj.pgStyle_PhonePortrait = 'position: absolute; left: 0px; top: 0px; width: 480px; height: 763px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_PhonePortrait = ["#FFFFFF","",0,0,1];
