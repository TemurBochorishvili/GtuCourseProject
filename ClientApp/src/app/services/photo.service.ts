import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class PhotoService {

    constructor(private http: HttpClient) {
        
     }

     upload(vehicleId: any, photo: any) {
         var formData = new FormData();
         formData.append('file', photo);
         console.log("vehicle Id is: " + vehicleId)

         return this.http.post(`/api/vehicles/${vehicleId}/photos`, formData);
     }

     getPhotos(vehicleId: any) {
         return this.http.get(`/api/vehicles/${vehicleId}/photos`);
     }
}
