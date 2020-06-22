$(document).ready(function(){
	$.ajax({
		url: "http://localhost/getData.php",
		method: "GET",
			dataType: "json",
		success: function(data) {
			console.log(data);
			var emp = [];
			var groups = [];

			for(var i in data) {
				emp.push(" " +data[i].FirstName);
				groups.push(data[i].TotalGroups);
			}

			var chartdata = {
				labels: emp,
				datasets : [
					{
						label: 'SHG Groups',
						backgroundColor: 'rgba(200, 200, 200, 200)',
						borderColor: 'rgba(200, 200, 200, 0.75)',
						hoverBackgroundColor: 'rgba(200, 200, 200, 1)',
						hoverBorderColor: 'rgba(200, 200, 200, 1)',
						data: groups
					}
				]
			};

			var ctx = document.getElementById("mycanvas");

			var barGraph = new Chart(ctx, {
				type: 'bar',
				data: chartdata
			});
		},
		error: function(data) {
			console.log(data);
		}
	});
});