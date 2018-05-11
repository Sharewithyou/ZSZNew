$(function () {

    //初始化iframe高度
    $("#menuFrame").height(window.innerHeight - 90);

    //菜单加载加载iframe 事件
    $("ul.nav-sidebar li a").click(function () {
        var url = $(this).attr("_target");
        $("#menuFrame").attr("src", url);
    })
})