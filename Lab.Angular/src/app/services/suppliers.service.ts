import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Supplier } from '../interfaces/supplier';

@Injectable({
  providedIn: 'root'
})
export class SuppliersService {
  private myAppUrl: string = environment.endpoint;
  private myApiUrl: string = 'api/Suppliers/';

  constructor(private http: HttpClient) { }

  getSuppliers(): Observable<Supplier[]> {
    return this.http.get<Supplier[]>(`${this.myAppUrl}${this.myApiUrl}`);
  }

  getSupplier(id: number): Observable<Supplier> {
    return this.http.get<Supplier>(`${this.myAppUrl}${this.myApiUrl}${id}`);
  }

  addSupplier(supplier: Supplier): Observable<Supplier> {
    return this.http.post<Supplier>(`${this.myAppUrl}${this.myApiUrl}`,supplier)
  }

  updateSupplier(id: number, supplier: Supplier): Observable<void> {
    return this.http.put<void>(`${this.myAppUrl}${this.myApiUrl}`, supplier)
  }

  deleteSupplier(id: number): Observable<void> {
    return this.http.delete<void>(`${this.myAppUrl}${this.myApiUrl}${id}`)}
}
