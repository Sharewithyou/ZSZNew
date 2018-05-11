//spin 初始化
var opts = {
    lines: 13, // The number of lines to draw
    length: 38, // The length of each line
    width: 17, // The line thickness
    radius: 45, // The radius of the inner circle
    scale: 1, // Scales overall size of the spinner
    corners: 1, // Corner roundness (0..1)
    color: '#ffffff', // CSS color or array of colors
    fadeColor: 'transparent', // CSS color or array of colors
    speed: 1, // Rounds per second
    rotate: 0, // The rotation offset
    animation: 'spinner-line-fade-quick', // The CSS animation name for the lines
    direction: 1, // 1: clockwise, -1: counterclockwise
    zIndex: 2e9, // The z-index (defaults to 2000000000)
    className: 'spinner', // The CSS class to assign to the spinner
    top: '50%', // Top position relative to parent
    left: '50%', // Left position relative to parent
    shadow: '0 0 1px transparent', // Box-shadow for the lines
    position: 'absolute' // Element positioning
};

//var opts = {
//    //innerImage: {url: '../img/logo.png', width: 56, height: 56 }, //内部图片            
//    lines: 13, // 花瓣数目
//    length: 20, // 花瓣长度
//    width: 10, // 花瓣宽度
//    radius: 30, // 花瓣距中心半径
//    corners: 1, // 花瓣圆滑度 (0-1)
//    rotate: 0, // 花瓣旋转角度
//    direction: 1, // 花瓣旋转方向 1: 顺时针, -1: 逆时针
//    color: '#5882FA', // 花瓣颜色
//    speed: 1, // 花瓣旋转速度
//    trail: 60, // 花瓣旋转时的拖影(百分比)
//    shadow: false, // 花瓣是否显示阴影
//    hwaccel: false, //spinner 是否启用硬件加速及高速旋转            
//    className: 'spinner', // spinner css 样式名称
//    zIndex: 2e9, // spinner的z轴 (默认是2000000000)
//    top: 'auto', // spinner 相对父容器Top定位 单位 px
//    left: 'auto', // spinner 相对父容器Left定位 单位 px
//    position: 'relative', // element position
//    progress: true,      // show progress tracker
//    progressTop: 0,       // offset top for progress tracker
//    progressLeft: 0       // offset left for progress tracker
//};

document.write("<div id='spanMark'></div>");
var target = document.getElementById('spanMark');
var spinner = new Spinner(opts).spin(target);

//监听加载状态改变  
document.onreadystatechange = completeLoading;

//加载状态为complete时移除loading效果  
function completeLoading() {
    if (document.readyState == "complete") {
        var loadingMask = document.getElementById('spanMark');
        loadingMask.parentNode.removeChild(loadingMask);
    }
}  