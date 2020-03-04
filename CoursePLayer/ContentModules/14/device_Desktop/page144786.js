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
	objData:	{"a":[0,32,0,[-0.5000000000006253,-0.49999999999874944,1009,608]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":608},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape146877.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
};
shape137392.rcdData.att_Desktop = 
{
	innerHtml:	"<svg viewBox=\"0 0 1009 45\" preserveAspectRatio=\"none\" focusable=\"false\" style=\"pointer-events: none; left: 0px; top: 0px; width: 100%; height: 100%; position: absolute;\"><g transform=\"translate(504.5 22.5)\" style=\"\">\n	<path d=\"M 0 0 L 1009 0 L 1009 45 L 0 45 L 0 0 Z\" style=\"stroke: rgb(1, 102, 177); stroke-width: 0; stroke-dasharray: none; stroke-linecap: round; stroke-linejoin: round; stroke-miterlimit: 10; fill: rgb(219, 102, 39); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100); pointer-events: auto;\" transform=\"translate(0 0) translate(-504.5, -22.5) \" stroke-linecap=\"round\"></path>\n</g>\n	<g transform=\"translate(504.5 22.5)\">\n		<text font-family=\"Arial,sans-serif\" font-size=\"15.9999996\" font-weight=\"normal\" style=\"stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-linejoin: miter; stroke-miterlimit: 10; fill: rgb(0,0,0); fill-rule: nonzero; opacity:1;filter:alpha(opacity=100);\">\n			<tspan x=\"0\" y=\"5.04\" fill=\"#000000\"></tspan>\n		</text>\n	</g>\n</svg>",
	cssText:	"visibility: inherit; position: absolute; left: 0px; top: 1.36779e-12px; width: 1009px; height: 45px; z-index: 2; overflow: visible; pointer-events: none;",
	cssClasses:	"",
	htmlId:		"tobj137392",
	bInsAnc:	0,
	cwObj:		{
		"name":	"headerbackground"
	},
	objData:	{"a":[0,160,0,[0,1.3677947663381929e-12,1009,45]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":0,"y":0,"width":1009,"height":45},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137392.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	objData:	{"a":[0,160,0,[1,45.000000000001364,1007,34]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1,"y":45,"width":1007,"height":34},"btnState":"disabled","fallbackImg":"<img src=\"images/desktop_shape137498.png\" alt=\"\" title=\"\" style=\"position: absolute; width: 100%; height: 100%; top: 0px; left: 0px;\">"}
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
	cssText:	"visibility: inherit; position: absolute; left: 25px; top: 554px; width: 34px; height: 34px; z-index: 23; cursor: pointer;",
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
	objData:	{"a":[4,352,0,[25,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":25,"y":554,"width":34,"height":34},"res":"images/prev.png","resClick":"images/prev.png","resOver":"images/prevHover.png"}
};
button353.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj353Img\" src=\"images/next.png\" style=\"position: absolute; left: 0px; top: 0px; width: 34px; height: 34px; border-style: none;\">",
	cssText:	"visibility: inherit; position: absolute; left: 948px; top: 554px; width: 34px; height: 34px; z-index: 24; cursor: pointer;",
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
	objData:	{"a":[4,352,0,[948,554,34,34]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":948,"y":554,"width":34,"height":34},"res":"images/next.png","resClick":"images/next.png","resOver":"images/nextHover.png"}
};
progress70386.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 306px; height: 6px;\"><div style=\"overflow: hidden; background-color: rgb(238, 238, 238); position: absolute; left: 0px; top: 0px; border: 1px solid rgb(102, 102, 102); width: 306px; height: 4px;\"><div style=\"overflow: hidden; position: absolute; left: 0px; top: 0px; width: 113px; height: 100%; background-color: rgb(204, 204, 204);\"></div></div><div name=\"dCon2\" style=\"position: absolute; width: 100%; left: 1px; bottom: 0px; height: 6px;\"></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 351px; top: 571px; width: 308px; height: 6px; z-index: 25;",
	cssClasses:	"",
	htmlId:		"tobj70386",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Progress Bar"
	},
	objData:	{"a":[0,16777312,0,[351,571,308,6]],"rcdOvr":{"res":0},"desktopRect":{"x":351,"y":571,"width":308,"height":6},"step":1,"range":30,"barPos":11,"tickTime":1000,"dwBarFlags":4,"imgsrc":"images/indicatie.gif"}
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
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 97px; width: 903px; height: 27px; z-index: 26;",
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
	cssText:	"visibility: inherit; position: absolute; left: 10px; top: 10px; width: 28px; height: 25px; z-index: 27; cursor: pointer;",
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
	cssText:	"visibility: inherit; position: absolute; left: 1047px; top: 0px; width: 1009px; height: 608px; z-index: 28;",
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
	cssText:	"visibility: inherit; position: absolute; left: 1450px; top: 139px; width: 373px; height: 373px; z-index: 29;",
	cssClasses:	"",
	htmlId:		"tobj148950",
	bInsAnc:	0,
	cwObj:		{
		"name":	"rotate-mobile"
	},
	objData:	{"a":[0,352,0,[1450,139,373,373]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":1450,"y":139,"width":373,"height":373}}
};
button145887.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145887Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 18px; height: 18px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 699px; top: 522px; width: 18px; height: 18px; z-index: 30; cursor: pointer;",
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
	objData:	{"a":[4,64,0,[699,522,18,18]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":699,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
button145882.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145882Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 18px; height: 18px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 724px; top: 522px; width: 18px; height: 18px; z-index: 31; cursor: pointer;",
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
	objData:	{"a":[4,64,0,[724,522,18,18]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":724,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
button145877.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145877Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 18px; height: 18px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 749px; top: 522px; width: 18px; height: 18px; z-index: 32; cursor: pointer;",
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
	objData:	{"a":[4,64,0,[749,522,18,18]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":749,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
button145872.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145872Img\" src=\"images/btn-slide.png\" style=\"position: absolute; left: 0px; top: 0px; width: 18px; height: 18px; border-style: none;\">",
	cssText:	"visibility: hidden; position: absolute; left: 774px; top: 522px; width: 18px; height: 18px; z-index: 33; cursor: pointer;",
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
	objData:	{"a":[4,64,0,[774,522,18,18]],"rcdOvr":{"res":0},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":774,"y":522,"width":18,"height":18},"res":"images/btn-slide.png","resClick":"images/btn-slide-act.png","resOver":"images/btn-slide-act.png"}
};
og145869.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145869",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145870.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; min-height: 44px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 440px; min-height: 44px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur: goed</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Helderheid: goed&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 482px; width: 440px; height: 44px; z-index: 9;",
	cssClasses:	"",
	htmlId:		"tobj145870",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 4"
	},
	objData:	{"a":[0,0,0,[524,482,440,44]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":44},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image146314.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj146314Img\" src=\"images/watertest1.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 440px; height: 330px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 150px; width: 440px; height: 330px; z-index: 10;",
	cssClasses:	"",
	htmlId:		"tobj146314",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest1"
	},
	objData:	{"a":[0,256,0,[524,150,440,330]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
image145871.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145871Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 18px; height: 18px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 699px; top: 522px; width: 18px; height: 18px; z-index: 34;",
	cssClasses:	"",
	htmlId:		"tobj145871",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[699,522,18,18]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":699,"y":522,"width":18,"height":18}}
};
og145866.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145866",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145867.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; min-height: 43px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 440px; min-height: 43px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur: slecht</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Helderheid: slecht&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 482px; width: 440px; height: 43px; z-index: 11;",
	cssClasses:	"",
	htmlId:		"tobj145867",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 2"
	},
	objData:	{"a":[0,0,0,[524,482,440,43]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":43},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image146318.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj146318Img\" src=\"images/watertest5.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 440px; height: 330px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 150px; width: 440px; height: 330px; z-index: 12;",
	cssClasses:	"",
	htmlId:		"tobj146318",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest5"
	},
	objData:	{"a":[0,256,0,[524,150,440,330]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
image145868.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145868Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 18px; height: 18px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 724px; top: 522px; width: 18px; height: 18px; z-index: 35;",
	cssClasses:	"",
	htmlId:		"tobj145868",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[724,522,18,18]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":724,"y":522,"width":18,"height":18}}
};
og145863.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145863",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
text145864.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 440px; min-height: 20px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur: slecht</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Helderheid: goed&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 482px; width: 440px; height: 20px; z-index: 13;",
	cssClasses:	"",
	htmlId:		"tobj145864",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 3"
	},
	objData:	{"a":[0,0,0,[524,482,440,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
image146316.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj146316Img\" src=\"images/watertest4.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 440px; height: 330px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 150px; width: 440px; height: 330px; z-index: 14;",
	cssClasses:	"",
	htmlId:		"tobj146316",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest4"
	},
	objData:	{"a":[0,256,0,[524,150,440,330]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
image145865.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145865Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 18px; height: 18px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 749px; top: 522px; width: 18px; height: 18px; z-index: 36;",
	cssClasses:	"",
	htmlId:		"tobj145865",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[749,522,18,18]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":749,"y":522,"width":18,"height":18}}
};
og145860.rcdData.att_Desktop = 
{
	innerHtml:	"",
	cssText:	"",
	cssClasses:	"",
	htmlId:		"og145860",
	bInsAnc:	undefined,
	objData:	{"a":[0,0,0,[]],"bReadLast":false}
};
image145861.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj145861Img\" src=\"images/btn-slide-act.png\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 18px; height: 18px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 774px; top: 522px; width: 18px; height: 18px; z-index: 37;",
	cssClasses:	"",
	htmlId:		"tobj145861",
	bInsAnc:	0,
	cwObj:		{
		"name":	"btn-slide-act"
	},
	objData:	{"a":[0,320,0,[774,522,18,18]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":774,"y":522,"width":18,"height":18}}
};
image146320.rcdData.att_Desktop = 
{
	innerHtml:	"<img id=\"tobj146320Img\" src=\"images/watertest3.jpg\" style=\"position: absolute; border-style: none; left: 0px; top: 0px; width: 440px; height: 330px;\">",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 150px; width: 440px; height: 330px; z-index: 15;",
	cssClasses:	"",
	htmlId:		"tobj146320",
	bInsAnc:	0,
	cwObj:		{
		"name":	"watertest3"
	},
	objData:	{"a":[0,256,0,[524,150,440,330]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":150,"width":440,"height":330}}
};
text145862.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; min-height: 20px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 440px; min-height: 20px;\"><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Kleur en helderheid: goed</span></em></p><p style=\"text-align:left\"><em><span style=\"color:#000000;font-family:calibri,open sans,opensans;font-size:12pt;\">Bezinksel: slecht&nbsp;</span></em></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 524px; top: 482px; width: 440px; height: 20px; z-index: 16;",
	cssClasses:	"",
	htmlId:		"tobj145862",
	bInsAnc:	0,
	cwObj:		{
		"name":	"bijschr 4"
	},
	objData:	{"a":[0,0,0,[524,482,440,20]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":524,"y":482,"width":440,"height":20},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text144791.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 818px; min-height: 26px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 818px; min-height: 26px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Je kunt zelf het drinkwater testen door het op 4 onderdelen te beoordelen:</span></p></div></div>",
	cssText:	"visibility: inherit; position: absolute; left: 50px; top: 127px; width: 818px; height: 26px; z-index: 17;",
	cssClasses:	"",
	htmlId:		"tobj144791",
	bInsAnc:	0,
	cwObj:		{
		"name":	"Text Block 1"
	},
	objData:	{"a":[0,32,0,[50,127,818,26]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":127,"width":818,"height":26},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
text147308.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; height: 92px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 432px; height: 84px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Kleur: </span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: totaal geen kleur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>: lichte verkleuring</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: duidelijke kleur; geel, bruin, enzovoort</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 160px; width: 440px; height: 92px; z-index: 18;",
	cssClasses:	"",
	htmlId:		"tobj147308",
	bInsAnc:	0,
	cwObj:		{
		"name":	"1"
	},
	objData:	{"a":[0,0,0,[50,160,440,92]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":160,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147312.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; height: 92px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 432px; height: 84px;\"><p style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\"><strong>Helderheid:</strong> ​</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: geheel helder</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>: troebel, maar nog wel doorzichtig</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: ondoorzichtig</span></p><p><span>​</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 50px; top: 269px; width: 440px; height: 92px; z-index: 19;",
	cssClasses:	"",
	htmlId:		"tobj147312",
	bInsAnc:	0,
	cwObj:		{
		"name":	"2"
	},
	objData:	{"a":[0,0,0,[50,269,440,92]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":50,"y":269,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147316.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; height: 92px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 432px; height: 84px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Bezinksel: </span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: water bevat geen deeltjes</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>: enkele deeltjes</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: bodem is geheel bedekt met modder- of ijzerdeeltjes</span></p><p><br><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Geur:</span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: totaal geen geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>:&nbsp;lichte geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: sterke geur; ruikt naar rotte eieren</span></p><p><span style=\"font-size:12pt; color: rgb(207, 42, 39);\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 525px; top: 160px; width: 440px; height: 92px; z-index: 20;",
	cssClasses:	"",
	htmlId:		"tobj147316",
	bInsAnc:	0,
	cwObj:		{
		"name":	"3"
	},
	objData:	{"a":[0,0,0,[525,160,440,92]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":525,"y":160,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text147320.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 440px; height: 92px; background-color: rgb(238, 238, 238);\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 4px; top: 4px; width: 432px; height: 84px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Geur:</span></strong></span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#009e0f;\">goed</span></strong>: totaal geen geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#db6627;\">matig</span></strong>:&nbsp;lichte geur</span></p><p><span style=\"font-family: calibri; font-size:12pt;\"><strong><span style=\"color:#cf2a27;\">slecht</span></strong>: sterke geur; ruikt naar rotte eieren</span></p><p><span style=\"font-size:12pt; color: rgb(207, 42, 39);\">&nbsp;</span></p></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 525px; top: 269px; width: 440px; height: 92px; z-index: 21;",
	cssClasses:	"",
	htmlId:		"tobj147320",
	bInsAnc:	0,
	cwObj:		{
		"name":	"4"
	},
	objData:	{"a":[0,0,0,[525,269,440,92]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#f9cb9c"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":525,"y":269,"width":440,"height":92},"dwTextFlags":0,"marginSize":4,"textPublishLang":"Inherit"}
};
text146323.rcdData.att_Desktop = 
{
	innerHtml:	"<div name=\"dCon\" style=\"position: absolute; left: 0px; top: 0px; width: 918px; min-height: 135px;\"><div name=\"dCon2\" class=\"ttxt\" style=\"left: 0px; top: 0px; width: 918px; min-height: 135px;\"><p style=\"text-align:left\"><span><strong><span style=\"font-family: calibri; font-size:12pt;\">Beoordeling:</span></strong></span></p><ul style=\"font-size:12pt;\"><li style=\"text-align:left\"><span style=\"font-family:calibri;\">Alle onderdelen zijn goed: 15% kans dat het water ongeschikt is.</span></li><li style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Alle onderdelen zijn slecht:&nbsp;</span><span style=\"font-family: calibri; font-size:12pt;\">water is altijd ongeschikt.</span><span style=\"font-family: calibri; font-size:12pt;\"> </span></li><li style=\"text-align:left\"><span style=\"font-family: calibri; font-size:12pt;\">Enkele onderdelen zijn matig: 35-75% kans dat het water ongeschikt is.&nbsp;</span></li></ul></div></div>",
	cssText:	"visibility: hidden; position: absolute; left: 48px; top: 385px; width: 918px; height: 135px; z-index: 22;",
	cssClasses:	"",
	htmlId:		"tobj146323",
	bInsAnc:	0,
	cwObj:		{
		"name":	"5"
	},
	objData:	{"a":[0,0,0,[48,385,918,135]],"rcdOvr":{"res":0},"borderEffect":{"outline":0,"outlineColor":"#000000","borderWeight":0,"lineStyle":0,"borderColor":"#000000"},"rotateEffect":{"angle":0,"anchorX":50,"anchorY":50},"desktopRect":{"x":48,"y":385,"width":918,"height":135},"dwTextFlags":0,"marginSize":0,"textPublishLang":"Inherit"}
};
rcdObj.rcdData.att_Desktop = 
{
	font:	{"bold":0,"italic":0,"underline":0,"size":"12","color":null,"bgColor":null,"name":"'Calibri'","lineHeight":"1.25","marginTop":"0px","marginBottom":"0px"},
	pageIdx:	11
};
rcdObj.pgWidth_Desktop = pgWidth_desktop;
rcdObj.preload_Desktop = ["images/prev.png","images/next.png","images/prevHover.png","images/nextHover.png","images/indicatie.gif","images/btn-slide-act.png","images/btn-slide.png","images/watertest1.jpg","images/watertest4.jpg","images/watertest5.jpg","images/watertest3.jpg","images/btn-close143187.png","images/btn-close-hover143188.png","images/logo-roodbont.png","images/btn-home.png","images/btn-home-H.png","images/logo-Aeres.png","images/shape9278.png","images/shape148517.png","images/shape9277.png","images/shape148518.png"];
rcdObj.pgStyle_Desktop = 'position: absolute; left: 0px; top: 0px; width: 1009px; height: 609px; overflow: hidden; background-size: auto;'
rcdObj.backgrd_Desktop = ["#eeeeee","",0,0,1];
