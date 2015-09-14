import toastr from 'toastr'

export default {
    success: function(msg) {
      toastr.success(msg);
      //  alert(msg);
    },
    error: function(err) {
      toastr.error(err);
      console.error(err);
    }
}
