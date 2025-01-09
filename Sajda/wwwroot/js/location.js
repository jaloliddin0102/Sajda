window.getUserLocation = function () {  
    return new Promise((resolve, reject) => {  
        if (navigator.geolocation) {  
            navigator.geolocation.getCurrentPosition(  
                (position) => {  
                    resolve({  
                        Latitude: position.coords.latitude,  
                        Longitude: position.coords.longitude  
                    });  
                },  
                (error) => {  
                    reject(error);  
                }  
            );  
        } else {  
            reject(new Error("Geolocation is not supported by this browser."));  
        }  
    });  
};
