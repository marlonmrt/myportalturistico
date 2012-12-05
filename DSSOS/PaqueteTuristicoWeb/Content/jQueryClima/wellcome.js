/* wellcome.js (v1.0.1) */

(function ($) {
     
    var weather = (function () {
    
      var $weather = $('#weather');
      
      var locations = $weather.data('locations') || '';
      locations = locations !== '' ? locations.split(',') : [];
          
      var index = 0;
      
      //var isPosible = $.isArray(locations) && locations.length > 0;
      
      function getWeather() {
        var where = $.trim(locations[index]);
        
        $.simpleWeather({
          location: where + ', peru',
          unit: 'c',
          success: function (weather) {
            var html;
            
            html = '<img src=' + weather.image + ' alt="">';
            html += '<p><strong>' + weather.temp + '&deg ' + weather.units.temp + '</strong><p>';
            html += '<p><em>' + weather.low + '&deg ' + weather.units.temp + '</em> (min) / <em>' + weather.high + '&deg ' + weather.units.temp + '</em> (max)</p>';
            
            $('h1', $weather).text(where);
            $('.forecast', $weather).html(html);
          },
          error: function (error) {
          }
        });
      }
      
      function next() {
        index = index + 1 >= locations.length ? 0 : index + 1;
        getWeather();
      }
      
      function previous() {
        index = index === 0 ? locations.length - 1 : index - 1;
        getWeather();
      }
      
      return {
        get: function () {
          getWeather();
        },
        previous: function () {
          previous();
        },
        next: function () {
          next();
        }
      }
    }());
    
    weather.get();
    
    $('a.previous', '#weather')
      .click(function () {
        weather.previous();
        return false;
      });
    
    $('a.next', '#weather')
      .click(function () {
        weather.next();
        return false;
      });

}(jQuery));
