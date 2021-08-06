jQuery(function ($) {
    //begin js here

    $validation = true;

	$.mask.definitions['~'] = '[+-]';
	$('#Phone').mask('(999) 999-9999');

	jQuery.validator.addMethod("Phone", function (value, element) {
		return this.optional(element) || /^\(\d{3}\) \d{3}\-\d{4}( x\d{1,6})?$/.test(value);
	}, "Enter a valid phone number.");

	$('#validation-form').validate({
		errorElement: 'div',
		errorClass: 'help-block',
		focusInvalid: false,
		ignore: "",
		rules: {
			Email: {
				required: true,
				email: true
			},
			Password: {
				required: true,
				minlength: 5
			},
			ConfirmPassword: {
				required: true,
				minlength: 5,
				equalTo: "#Password"
			},
			FirstName: {
				required: true
			},
			Phone: {
				required: true,
				Phone: 'required'
			},
			url: {
				required: true,
				url: true
			},
			comment: {
				required: true
			},
			state: {
				required: true
			},
			platform: {
				required: true
			},
			subscription: {
				required: true
			},
			gender: {
				required: true,
			},
			agree: {
				required: true,
			}
		},

		messages: {
			Email: {
				required: "Please provide a valid email.",
				email: "Please provide a valid email."
			},
			Password: {
				required: "Please specify a password.",
				minlength: "Please specify a secure password."
			},
			state: "Please choose state",
			subscription: "Please choose at least one option",
			gender: "Please choose gender",
			agree: "Please accept our policy"
		},


		highlight: function (e) {
			$(e).closest('.form-group').removeClass('has-info').addClass('has-error');
		},

		success: function (e) {
			$(e).closest('.form-group').removeClass('has-error');//.addClass('has-info');
			$(e).remove();
		},

		errorPlacement: function (error, element) {
			if (element.is('input[type=checkbox]') || element.is('input[type=radio]')) {
				var controls = element.closest('div[class*="col-"]');
				if (controls.find(':checkbox,:radio').length > 1) controls.append(error);
				else error.insertAfter(element.nextAll('.lbl:eq(0)').eq(0));
			}
			else if (element.is('.select2')) {
				error.insertAfter(element.siblings('[class*="select2-container"]:eq(0)'));
			}
			else if (element.is('.chosen-select')) {
				error.insertAfter(element.siblings('[class*="chosen-container"]:eq(0)'));
			}
			else error.insertAfter(element.parent());
		},

		submitHandler: function (form) {
		},
		invalidHandler: function (form) {
		}
	});

	//call save button Save

	$("#Save").click(function (event) {

		if ($('#validation-form').valid())
		{
			var valdata = $("#validation-form").serialize();

			jQuery.ajax({
				url: '/Drivers/CreateUser',
				type: "POST",
				data: valdata,
				dataType: "json",
				contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
				success: function (response) {
					if (response != null) {
						//console.log(JSON.stringify(response)); //it comes out to be string 

						//we need to parse it to JSON
						var data = $.parseJSON(response);

						//console.log(data.Message);

						if (data.status == "000") {

							bootbox.dialog({
								message: data.message,
								buttons: {
									"success": {
										"label": "OK",
										"className": "btn-sm btn-primary"
									}
								}
							});

						} else {

							bootbox.dialog({
								message: data.message,
								buttons: {
									"success": {
										"label": "OK",
										"className": "btn-sm btn-primary"
									}
								}
							});
						}

						//redirect after 2 seconds
						window.setTimeout(function () {
							window.location.href = '/Drivers/Index';
						}, 2000);

					}
				},
				error: function (e) {
					console.log(e.responseText);
				}
			});
        }	

		event.preventDefault();
	});

})