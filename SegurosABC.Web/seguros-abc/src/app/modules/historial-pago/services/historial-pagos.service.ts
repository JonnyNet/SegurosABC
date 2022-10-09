import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HistorialPagosService {

  private server = `${environment.webApiUrl}${environment.endpointHistorialPago}`

  constructor(private readonly http: HttpClient) { }


  ObtenerHistorialPagos(cedula = undefined) {
    let params;
    if(cedula){
      params = { cedula }
    }

    return this.http.get(this.server, { params });
  }

}
