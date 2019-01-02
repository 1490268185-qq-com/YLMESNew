﻿$(function () {
    layui.use(['table', 'layer', 'form'], function () {

        var table = layui.table, layer = layui.layer
        , form = layui.form;
        $("#SupplierSel").click(function () {
            var NameSearch = $("#Name").val().trim();
            var Select = $("#s option:selected").text();
            table.render({
                elem: '#tw'
                , url: '/ApplierList/GetSupplierlist?Name=' + NameSearch + '&Status=' + Select
                , page: true
                , height: 'full-20'
                , limit: 15
                , cols: [[
                 { field: '序号', width: 80, title: '序号' }
               , { field: '名称', width: 205, title: '名称', edit: Text }
               , { field: '地址',  title: '地址', edit: Text }
               , { field: '联系人', width: 90, title: '联系人', edit: Text }
               , { field: '电话', width: 190, title: '电话', edit: Text }
               , { field: '手机', width: 190, title: '手机', edit: Text }
               , { field: '货品品类', width: 150, title: '货品品类', toolbar: "#Category" }
               , { field: '级别', width: 150, title: '级别', toolbar: "#Level" }
               , { field: '优势分析', width: 200, title: '优势分析  ', toolbar: "#Advantage" }
               , { field: '审核状态', width: 100, title: '审核状态' }
               , { field: 'right', width: 238, align: 'center', toolbar: '#bsarDemo' }
                ]]
            });
        });
        var Category1 = null;
        var Level1 = null;
        var Advantage1 = null;
        form.on('select(Category)', function (data) {

            //得到select原始DOM对象
            Category1 = data.value;
            layer.msg(Category1)
          

        });
        form.on('select(Level)', function (data) {
            //得到select原始DOM对象
            Level1 = data.value;
            layer.msg(Level1)
            //得到被选中的值

        });
        form.on('select(Advantage)', function (data) {
            //得到select原始DOM对象
            Advantage1 = data.value;
            layer.msg(Advantage1)
            //得到被选中的值

        });

        table.on('tool(demo)', function (obj) { //注：tool 是工具条事件名，test 是 table 原始容器的属性 lay-filter="对应的值"
            var data = obj.data //获得当前行数据
                , layEvent = obj.event; //获得 lay-event 对应的值  
            var ApplierID = data.序号;
            var ApplierName = data.名称;
            var Address = data.地址;
            var Contact = data.联系人;
            var Tel = data.电话;
            var Mobile = data.手机;
            var Category = Category1;
            var Level = Level1;
            var Advantage = Advantage1;

            if (Category1 == null) {
                Category = data.货品品类;

            }
            if (Level1 == null) {
                Level = data.级别;

            }
            if (Advantage1 == null) {
                Advantage = data.优势分析;


            }
            if (layEvent === 'detail') {
                layer.msg(Level)
            } else if (layEvent === 'del') {
                layer.confirm('真的删除行么', function (index) {
                    $.ajax({
                        url: "/ApplierList/ApplierListdel",
                        data: { ApplierID: ApplierID },
                        type: "post",
                        dataType: "text",
                        success: function (data) {
                            if (data == "true") {
                                layer.msg('删除成功');
                            }
                        }
                    });
                    obj.del(); //删除对应行（tr）的DOM结构
                    layer.close(index);
                    //向服务端发送删除指令
                });
            } else if (layEvent === 'edit') {
                $.ajax({
                    type: "post",
                    url: "/ApplierList/ApplierListUpdata",
                    data: { ApplierID: ApplierID, ApplierName: ApplierName, Address: Address, Contact: Contact, Tel: Tel, Mobile: Mobile, Category: Category, Level: Level, Advantage: Advantage },
                    dataType: "text",
                    success: function (data) {
                        if (data == "true") {
                            layer.msg('修改成功');
                            var Category1 = null;
                            var Level1 = null;
                            var Advantage1 = null;
                            $("#SupplierSel").click()
                        }
                    }
                });

            } else if (layEvent === 'sh' && data.审核状态 === "未审核") {
                    layer.confirm('是否通过审核！', {
                        title: "友力提示", skin: "my-skin",
                        btn: ['确定', '取消'], btn1: function () {
                            layer.closeAll();
                            $.ajax({
                                url: "/ApplierList/ApplierListReview?id="+data.序号,
                                type: 'post',
                                success: function (data) {
                                    if (data == "true") {
                                        layer.msg("修改成功", { icon: 6 });
                                        $("#SupplierSel").click();
                                    }
                                    if (data == "false") {
                                        layer.msg('修改失败!', { icon: 5 });
                                        return false;
                                    }
                                }
                            });
                        }
                    });
            } else if (layEvent === 'bb')
            {
               layer.open({
                    type: 2
                 , content: '/ApplierList/Material?ApplierID=' + ApplierID
                  , area: ['80%', '60%']
                 , anim: 2
                });
            }
        });
    });
});