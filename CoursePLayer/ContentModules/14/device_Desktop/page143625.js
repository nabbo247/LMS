if (window.VarCurrentView) VarCurrentView.set('Desktop');
function init_Desktop() {
	if ( rcdObj.view != 'Desktop' ) return;
	if (!isOPAPub() || isLOPopup()) window.init_page();
	preload(rcdObj['preload_'+rcdObj.view]);
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

    if( keyFlags == 0 && keyVal == 37 ){action137337(); keyAvail = false; };

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
	objData:	{"a":[0,32,0,[-0.5000000000004547,-0.4999999999990905,1009,608]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 1009 45\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(504.5 22.5)\" style=\"\">\n	<path d=\"M 0 0 L 1009 0 L 1009 45 L 0 45 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-504.5, -22.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(504.5 22.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 9.9476e-13px; width: 1009px; height: 45px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,9.947598300641403e-13,1009,45]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.000000000000995,1007,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
image148817.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148817Img\" src=\"images/logo-Aeres.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 140px; height: 61px;\">",
	cssText:	"visibility: inherit; position: absolute; left: 826px; top: 9px; width: 140px; height: 61px; z-index: 6;",
	cssClasses:	"",
	htmlId:		"tobj148817",
	bInsAnc:	0,
	cwObj:		{
		"name":	"logo-Aeres"
	},
	objData:	{"a":[0,288,0,[826,9,140,61]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":826,"y":9,"width":140,"height":61}}
};
button352.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj352Img\" src=\"images/prev.png\" style=\"position: absolute; left: 0px; top: 0px; width: 34px; height: 34px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 25px; top: 554px; width: 34px; height: 34px; z-index: 42; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj352",
	bInsAnc:	1,
	cwObj:		{
		"name":	"prev page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page143621.html',false,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[25,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 34px; height: 34px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 948px; top: 554px; width: 34px; height: 34px; z-index: 43; cursor: pointer;",
	cssClasses:	"",
	htmlId:		"tobj353",
	bInsAnc:	1,
	cwObj:		{
		"name":	"next page",
		"arChld":
	[
		{type:6,on:2,delay:0,name:'OnMClkGoTo',actItem:function(){ trivExitPage('page144762.html',true,false);
    if(typeof pF == 'function') pF(); }}
	]
	},
	objData:	{"a":[4,352,0,[948,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 306px; height: 6px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 306px; height: 4px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 82px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 351px; top: 571px; width: 308px; height: 6px; z-index: 44;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[351,571,308,6]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":8,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
};
text354.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 860px; min-height: 40px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 860px; min-height: 40px;\"><p style=\"margin-left:0px;text-indent:0px;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span><strong><span style=\"font-size:22pt; color: rgb(255, 255, 255); font-family: calibri;\">Vleeskuikensignalen -&nbsp;</span></strong><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:22pt;\">Water en strooisel</span></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 5px; width: 860px; height: 40px; z-index: 7;",
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
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 47px; width: 900px; height: 34px; z-index: 8;",
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
text146548.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 903px; min-height: 27px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 903px; min-height: 27px;\"><p leglh=\"1.218\" style=\"margin-left:0px;text-indent:0px;line-height:1.218;margin-top:0px;margin-bottom:0px;\" align=\"left\"><span style=\"font-size:14pt; font-family: calibri;\"><strong><span style=\"color: rgb(0, 0, 0);\">Title of Page</span></strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000; \"><strong> </strong></span><span style=\" font-size:14pt; font-family:\'Calibri\', sans-serif; color:#000000;\"> </span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 97px; width: 903px; height: 27px; z-index: 45;",
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
	objData:	{"a":[0,96,0,[50,97,903,27]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":97,"width":903,"height":27},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
button148245.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj148245Img\" src=\"images/btn-home.png\" style=\"position: absolute; left: 0px; top: 0px; width: 28px; height: 25px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 10px; top: 10px; width: 28px; height: 25px; z-index: 46; cursor: pointer;",
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
	objData:	{"a":[4,352,0,[10,10,28,25]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":10,"y":10,"width":28,"height":25},"res":"images/btn-home.png","resClick":"images/btn-home.png","resOver":"images/btn-home-H.png"}
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
	cssText:	"visibility: inherit; position: absolute; left: 1047px; top: 0px; width: 1009px; height: 608px; z-index: 47;",
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
	cssText:	"visibility: inherit; position: absolute; left: 1450px; top: 139px; width: 373px; height: 373px; z-index: 48;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[1450,139,373,373]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
text143626.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 900px; min-height: 90px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 900px; min-height: 90px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Water kan ook schadelijke, niet-gewenste stoffen bevatten die vervolgens in de kip terechtkomen. De kwaliteit van leidingwater is over het algemeen goed. Dit geldt niet altijd voor de water uit eigen bron. Om die kwaliteit op peil te krijgen, kunnen technische hulpmiddelen worden gebruikt, zoals een ontijzeringsinstallatie en omgekeerde osmosesystemen (filtert alle stoffen uit water).&nbsp;</span></p><p style=\"text-align:left\"><span>&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 125px; width: 900px; height: 90px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj143626",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[50,125,900,90]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":125,"width":900,"height":90},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og146520.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og146520",
	bInsAnc:	undefined,
	objData:	{"a":[0,32,0,[]],"bReadLast":false}
};
shape145797.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 910 23\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(455 11.5)\" style=\"\">\n	<path d=\"M 0 0 L 910 0 L 910 23 L 0 23 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-455, -11.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(455 11.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 204px; width: 910px; height: 23px; z-index: 10; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145797",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[50,204.0000000000001,910,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":204,"width":910,"height":23},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145797.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape145798.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 910 30\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(455 15)\" style=\"\">\n	<path d=\"M 0 0 L 910 0 L 910 30 L 0 30 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-455, -15) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(455 15)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 292px; width: 910px; height: 30px; z-index: 11; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145798",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[50,292.0000000000001,910,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":292,"width":910,"height":30},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145798.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape145799.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 910 30\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(455 15)\" style=\"\">\n	<path d=\"M 0 0 L 910 0 L 910 30 L 0 30 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-455, -15) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(455 15)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 354px; width: 910px; height: 30px; z-index: 12; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145799",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[50,354.0000000000001,910,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":354,"width":910,"height":30},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145798.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape145800.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 910 30\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(455 15)\" style=\"\">\n	<path d=\"M 0 0 L 910 0 L 910 30 L 0 30 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-455, -15) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(455 15)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 434px; width: 910px; height: 30px; z-index: 13; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145800",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[50,434.0000000000001,910,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":434,"width":910,"height":30},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145798.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape145801.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 910 30\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(455 15)\" style=\"\">\n	<path d=\"M 0 0 L 910 0 L 910 30 L 0 30 L 0 0 Z\" style=\"stroke: rgb(69, 143, 208); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(238, 238, 238); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-455, -15) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(455 15)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 497px; width: 910px; height: 30px; z-index: 14; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj145801",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Rectangle"
	},
	objData:	{"a":[0,32,0,[50,497.0000000000001,910,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":497,"width":910,"height":30},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape145798.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
text145823.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 166px; min-height: 21px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 166px; min-height: 21px;\"><p style=\"text-align:left\"><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\"><strong>Signaal</strong>&nbsp;</span></p><p><span style=\"color: rgb(255, 255, 255);\">&nbsp;</span></p><p><span style=\"color: rgb(255, 255, 255);\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 58px; top: 204px; width: 166px; height: 21px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj145823",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 3"
	},
	objData:	{"a":[0,32,0,[58,204,166,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":58,"y":204,"width":166,"height":21},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145824.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 337px; min-height: 21px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 337px; min-height: 21px;\"><p style=\"text-align:left\"><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\"><strong>Oorzaak</strong></span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 456px; top: 204px; width: 337px; height: 21px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj145824",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 2"
	},
	objData:	{"a":[0,32,0,[456,204,337,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":204,"width":337,"height":21},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145825.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 121px; min-height: 23px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 121px; min-height: 23px;\"><p style=\"text-align:left\"><span style=\"color: rgb(255, 255, 255); font-family: calibri; font-size:12pt;\"><strong>Schadelijk (mg/l)</strong>&nbsp;</span></p><p><br><span style=\"color: rgb(255, 255, 255);\">&nbsp;</span></p><p><span style=\"color: rgb(255, 255, 255);\">&nbsp;</span></p><p><span style=\"color: rgb(255, 255, 255);\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 817px; top: 204px; width: 121px; height: 23px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj145825",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 4"
	},
	objData:	{"a":[0,32,0,[817,204,121,23]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":817,"y":204,"width":121,"height":23},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147205.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147205",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text146299.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 178px; min-height: 39px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 178px; min-height: 39px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Verzwakte afweer&nbsp;</span><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\"> </span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 501px; width: 178px; height: 39px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj146299",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,501,178,39]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":501,"width":178,"height":39},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146298.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 308px; min-height: 37px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 308px; min-height: 37px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Mycotoxinen (geproduceerd door schimmels)&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 501px; width: 308px; height: 37px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj146298",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,501,308,37]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":501,"width":308,"height":37},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text146297.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 142px; min-height: 30px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 142px; min-height: 30px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">Geen norm&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 822px; top: 498px; width: 142px; height: 30px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj146297",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[822,498,142,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":822,"y":498,"width":142,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147204.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147204",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145820.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 357px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 357px; min-height: 25px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Darmstoornis, diverse bacteriële problemen&nbsp;</span><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\"> </span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 470px; width: 357px; height: 25px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj145820",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,470,357,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":470,"width":357,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145821.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 308px; min-height: 37px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 308px; min-height: 37px;\"><p style=\"text-align: left;\"><em><span style=\"font-family: calibri; color: rgb(0, 0, 0); font-size:12pt;\">E.&nbsp;coli</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 470px; width: 308px; height: 37px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj145821",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,470,308,37]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":470,"width":308,"height":37},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145822.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 142px; min-height: 30px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 142px; min-height: 30px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">&gt; 100 (kve/ml)&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 822px; top: 467px; width: 142px; height: 30px; z-index: 23;",
	cssClasses:	"",
	htmlId:		"tobj145822",
	bInsAnc:	0,
	cwObj:		{
		"name":	"7b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[822,467,142,30]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":822,"y":467,"width":142,"height":30},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147203.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147203",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145817.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 178px; min-height: 39px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 178px; min-height: 39px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Darmstoornis</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 439px; width: 178px; height: 39px; z-index: 24;",
	cssClasses:	"",
	htmlId:		"tobj145817",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,439,178,39]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":439,"width":178,"height":39},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145818.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 325px; min-height: 24px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 325px; min-height: 24px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">IJzer&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 439px; width: 325px; height: 24px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj145818",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,439,325,24]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":439,"width":325,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145819.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 141px; min-height: 24px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 141px; min-height: 24px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">&gt; 5,0</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 823px; top: 439px; width: 141px; height: 24px; z-index: 26;",
	cssClasses:	"",
	htmlId:		"tobj145819",
	bInsAnc:	0,
	cwObj:		{
		"name":	"6b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[823,439,141,24]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":823,"y":439,"width":141,"height":24},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147202.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147202",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145814.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 375px; min-height: 31px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 375px; min-height: 31px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Geblokkeerde zenuwgeleiding; geur van rotte eieren&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 390px; width: 375px; height: 31px; z-index: 27;",
	cssClasses:	"",
	htmlId:		"tobj145814",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,390,375,31]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":390,"width":375,"height":31},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145815.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 341px; min-height: 41px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 341px; min-height: 41px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Sulfide, een omzetting van sulfaat o.i.v. bepaalde bacteriën&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 390px; width: 341px; height: 41px; z-index: 28;",
	cssClasses:	"",
	htmlId:		"tobj145815",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,390,341,41]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":390,"width":341,"height":41},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145816.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 142px; min-height: 22px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 142px; min-height: 22px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">&gt; 250&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 822px; top: 390px; width: 142px; height: 22px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj145816",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[822,390,142,22]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":822,"y":390,"width":142,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147201.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147201",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145811.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 386px; min-height: 25px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 386px; min-height: 25px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Hersenverschijnselen: draainekken en verlammingen&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 360px; width: 386px; height: 25px; z-index: 30;",
	cssClasses:	"",
	htmlId:		"tobj145811",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,360,386,25]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":360,"width":386,"height":25},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145812.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 122px; min-height: 28px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 122px; min-height: 28px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Natrium&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 360px; width: 122px; height: 28px; z-index: 31;",
	cssClasses:	"",
	htmlId:		"tobj145812",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,360,122,28]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":360,"width":122,"height":28},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145813.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 141px; min-height: 28px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 141px; min-height: 28px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">&gt; 200&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 823px; top: 360px; width: 141px; height: 28px; z-index: 32;",
	cssClasses:	"",
	htmlId:		"tobj145813",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[823,360,141,28]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":823,"y":360,"width":141,"height":28},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147192.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147192",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145808.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 178px; min-height: 22px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 178px; min-height: 22px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Diarree</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 329px; width: 178px; height: 22px; z-index: 33;",
	cssClasses:	"",
	htmlId:		"tobj145808",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,329,178,22]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":329,"width":178,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145809.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 122px; min-height: 22px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 122px; min-height: 22px;\"><p style=\"text-align: left;\"><span style=\"font-family: calibri; font-size:12pt;\">Kalium&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 329px; width: 122px; height: 22px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj145809",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,329,122,22]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":329,"width":122,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145810.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 365px; min-height: 22px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 365px; min-height: 22px;\"></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 599px; top: 329px; width: 365px; height: 22px; z-index: 35;",
	cssClasses:	"",
	htmlId:		"tobj145810",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[599,329,365,22]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":599,"y":329,"width":365,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147191.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147191",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145805.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 175px; min-height: 22px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 175px; min-height: 22px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Luchtweginfecties&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 296px; width: 175px; height: 22px; z-index: 36;",
	cssClasses:	"",
	htmlId:		"tobj145805",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,296,175,22]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":296,"width":175,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145806.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 325px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 325px; min-height: 20px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Nitraat (kan in nitriet worden omgezet)&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 296px; width: 325px; height: 20px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj145806",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,296,325,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":296,"width":325,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145807.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 141px; min-height: 22px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 141px; min-height: 22px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">&gt; 200&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 823px; top: 297px; width: 141px; height: 22px; z-index: 38;",
	cssClasses:	"",
	htmlId:		"tobj145807",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[823,297,141,22]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":823,"y":297,"width":141,"height":22},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
og147190.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og147190",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145802.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 385px; min-height: 80px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 385px; min-height: 80px;\"><p><span style=\"font-family: calibri; font-size:12pt;\">Afname zuurstofopname bloed. </span></p><p><span style=\"font-family: calibri; font-size:12pt;\">Gevolg: kam, lellen en kop worden blauw, dieren worden sloom.&nbsp;Verminderde vruchtbaarheid</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 56px; top: 229px; width: 385px; height: 80px; z-index: 39;",
	cssClasses:	"",
	htmlId:		"tobj145802",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[56,229,385,80]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":56,"y":229,"width":385,"height":80},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145803.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 350px; min-height: 21px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 350px; min-height: 21px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Nitriet&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 456px; top: 230px; width: 350px; height: 21px; z-index: 40;",
	cssClasses:	"",
	htmlId:		"tobj145803",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1a"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[456,230,350,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":456,"y":230,"width":350,"height":21},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text145804.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 141px; min-height: 21px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 141px; min-height: 21px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">&gt; 1,0&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 823px; top: 230px; width: 141px; height: 21px; z-index: 41;",
	cssClasses:	"",
	htmlId:		"tobj145804",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1b"
	},
	objData:	{"a":[32,0,[35,0,7,0,0,0],[823,230,141,21]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":823,"y":230,"width":141,"height":21},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_Desktop = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	8
};
rcdObj.pgWidth_Desktop = pgWidth_desktop;
rcdObj.preload_Desktop = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png"];
rcdObj.pgStyle_Desktop = 'position: absolute; left: 0px; top: 0px; width: 1009px; height: 609px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_Desktop = ["#eeeeee","",0,0,1];
