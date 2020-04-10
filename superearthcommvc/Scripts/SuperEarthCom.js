var SEC = (function () {
    var home = document.getElementById('home');
    var about = document.getElementById('about');

    'use strict';

    var secSuper = `<div>
<?xml version="1.0" encoding="UTF-8" standalone="no"?>
<svg
   xmlns:dc="http://purl.org/dc/elements/1.1/"
   xmlns:cc="http://creativecommons.org/ns#"
   xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#"
   xmlns:svg="http://www.w3.org/2000/svg"
   xmlns="http://www.w3.org/2000/svg"
   xmlns:sodipodi="http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
   xmlns:inkscape="http://www.inkscape.org/namespaces/inkscape"
   width="100%"
   height="100%"
   viewBox="0 0 700 200"
   version="1.1"
   xml:space="preserve"
   style="fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;"
   id="svg3749"
   sodipodi:docname="superEarthCom.svg"
   inkscape:version="0.92.2 (5c3e80d, 2017-08-06)"><metadata
     id="metadata3755"><rdf:RDF><cc:Work
         rdf:about=""><dc:format>image/svg+xml</dc:format><dc:type
           rdf:resource="http://purl.org/dc/dcmitype/StillImage" /></cc:Work></rdf:RDF></metadata><defs
     id="defs3753" /><sodipodi:namedview
     pagecolor="#ffffff"
     bordercolor="#666666"
     borderopacity="1"
     objecttolerance="10"
     gridtolerance="10"
     guidetolerance="10"
     inkscape:pageopacity="0"
     inkscape:pageshadow="2"
     inkscape:window-width="1920"
     inkscape:window-height="1001"
     id="namedview3751"
     showgrid="false"
     inkscape:zoom="2.5142857"
     inkscape:cx="279.40341"
     inkscape:cy="100"
     inkscape:window-x="2391"
     inkscape:window-y="-9"
     inkscape:window-maximized="1"
     inkscape:current-layer="svg3749" /><g
     transform="matrix(6.37654,-0.0251339,0.0215885,4.02396,-162.021,-186.642)"
     id="g3735"><g
       id="Layer1"><text
         x="25.844px"
         y="61.049px"
         style="font-family:'MartianBThai-Regular', 'Martian B Thai';font-size:11.928px;fill:rgb(61,74,205);stroke:rgb(8,9,22);stroke-width:0.31px;"
         id="text3732">Sup<tspan
   x="46.408px 52.826px "
   y="61.049px 61.049px "
   id="tspan3728">er</tspan> Ea<tspan
   x="75.43px "
   y="61.049px "
   id="tspan3730">r</tspan>th C  m</text>
</g></g><g
     transform="matrix(0,0.0145153,0.0174261,0,513.29945,26.003745)"
     id="g3747"><path
       d="M 283,2239 C 200,2231 115,2188 73,2132 -36,1987 -1,1697 162,1394 l 38,-71 -9,-102 C 174,1019 210,840 301,671 480,339 851,145 1226,188 l 98,11 50,-29 c 247,-140 537,-200 687,-142 226,89 246,379 55,777 l -63,130 10,94 c 21,197 -26,410 -129,583 -66,111 -212,257 -319,319 -187,108 -381,151 -589,129 l -98,-10 -52,29 c -197,113 -431,176 -593,160 z m 207,-236 c 30,-8 77,-26 104,-40 l 51,-26 -25,-16 c -48,-32 -172,-134 -177,-147 -2,-7 18,-58 45,-112 173,-350 543,-758 926,-1020 111,-77 325,-192 356,-192 21,0 95,80 142,152 l 32,50 19,-44 c 44,-103 59,-221 37,-298 -16,-54 -24,-62 -76,-70 -238,-36 -646,208 -1065,636 -401,412 -664,841 -632,1036 7,48 59,105 100,111 38,5 98,-2 163,-20 z"
       style="fill:#3d4acd;fill-rule:nonzero;stroke:#020416;stroke-width:103.69999695px"
       id="path3745"
       inkscape:connector-curvature="0" /></g></svg></div>`;

    var secSub = `<svg width="100%" height="100%" viewBox="0 0 168 19" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" xml:space="preserve" xmlns:serif="http://www.serif.com/" style="fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;">
    <g transform="matrix(0.508322,0,0,0.678424,-40.0126,-39.9515)">
        <g transform="matrix(1.36796,0,0,1,-28.3999,0)">
            <text x="77.182px" y="79.511px" style="font-family:'MartianBThai-Regular', 'Martian B Thai';font-size:27.853px;fill:rgb(61,74,205);stroke:rgb(8,9,22);stroke-width:1.46px;">C<tspan x="93.042px 108.764px 124.942px 136.585px 151.749px 167.927px " y="79.511px 79.511px 79.511px 79.511px 79.511px 79.511px ">ontent</tspan> M<tspan x="209.73px 224.052px 236.698px 250.937px 266.346px " y="79.511px 79.511px 79.511px 79.511px 79.511px ">arket</tspan>ing</text>
        </g>
    </g>
</svg>`;
    

    

    function getSub() { }

    function submitContact(_url) {
        var url = _url;
      
        var nme = $('#Name').val();
        var emil = $('#Email').val();
        var mssage = $('#Message').val();

        $.ajax({
            type: 'POST',
            url: url,
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            data: $("form[name=contactForm]").serialize(),
            success: function (data) {
                console.log(data);
            },
            error: function (data) {
                console.log(data);
            }
        });
    

    }

  
    function toggleVisibility(element) {
        var elem = document.getElementById(element.id);
        var home = document.getElementById('home');
        var about = document.getElementById('about');
        if (element.id === 'homeLnk') {
            if (home.style.display === "none") {
                home.style.display = "block";
                about.style.display = "none";
            }
        }
        else if (element.id === 'aboutLnk') {
            if (about.style.display === "none") {
                about.style.display = "block";
                home.style.display = "none";
                }           
            }
    }

    return {
   
        getSub: getSub,
        submitContact: submitContact,
        toggleVisibility: toggleVisibility
    };


  


})();