import { SaveVehicle, Vehicle } from './../models/vehicle';
import { Injectable } from '@angular/core';

import 'rxjs/add/operator/map';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class VehicleService {
  private readonly vehiclesEndpoint = '/api/vehicles';


  constructor(private http: HttpClient) {   }

  getMakes() {
    return this.http.get<any>('/api/makes');
  }
  
  getFeatures() {
    return this.http.get<any>('api/features');
  }

  create(vehicle: any) {
    return this.http.post<Vehicle>(this.vehiclesEndpoint, vehicle);
  }

  getVehicle(id: any) {
    return this.http.get<Vehicle>(this.vehiclesEndpoint + '/' + id);
  }

  update(vehicle: SaveVehicle) {
    return this.http.put<Vehicle>(this.vehiclesEndpoint + '/' + vehicle.id, vehicle);
  }
  
  delete(id: any) {
    return this.http.delete(this.vehiclesEndpoint + '/' + id);
  }

  getVehicles(filter: any) {
    return this.http.get(this.vehiclesEndpoint + '?' + this.toQueryString(filter));
  }

  toQueryString(obj: any) {
    var parts = [];
    for(var property in obj) {
      var value = obj[property];
      if(value != null && value != undefined) {
        parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
      }
    }
    return parts.join('&');
  }
}
