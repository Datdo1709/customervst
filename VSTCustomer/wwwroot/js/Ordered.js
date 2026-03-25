$(document).ready(function () {
    // Chỉ cho phép chọn 1 checkbox
    $(".row-select").on("change", function () {
        $(".row-select").not(this).prop("checked", false);
        if ($(this).is(":checked")) {
            var id = $(this).val();
            // Nếu cần, gửi Ajax lên server để lưu ID đã chọn
            $.post("/Order/SelectRow", { id: id });
        }
    });

    // Mở form Add
    $("#btn-add").on("click", function () {
        $("#formTitle").text("Thêm Order");
        $("#orderForm").show();
    });

    // Đóng form
    $("#btnCloseForm").on("click", function () {
        $("#orderForm").hide();
    });
});