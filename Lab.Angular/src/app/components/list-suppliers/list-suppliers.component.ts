import { AfterViewInit,Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Supplier } from 'src/app/interfaces/supplier';
import { SuppliersService } from 'src/app/services/suppliers.service';

@Component({
  selector: 'app-list-suppliers',
  templateUrl: './list-suppliers.component.html',
  styleUrls: ['./list-suppliers.component.css']
})
export class ListSuppliersComponent implements OnInit,AfterViewInit {
  displayedColumns: string[] = ['supplierId', 'companyName', 'contactName', 'acciones'];
  dataSource = new MatTableDataSource<Supplier>();
  loading: boolean = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _snackBar: MatSnackBar, private _supplierService : SuppliersService) { }

  ngOnInit(): void {}

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    this.paginator._intl.itemsPerPageLabel = 'Items por pág'
  }
  
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  traerSuppliers() {
    this.loading = true;
    this._supplierService.getSuppliers().subscribe(data => {
      this.loading = false;
      this.dataSource.data = data;
    }, error => {
      this.loading = false;
      this._snackBar.open('¡Error!', '', {
        duration: 4000,
        horizontalPosition: 'right',
      })
    });
  }
  
  borrarSupplier(id: number) {
    this.loading = true;
    this._supplierService.deleteSupplier(id).subscribe(() => {
      this._snackBar.open('Producto eliminado correctamente', '', {
        duration: 4000,
        horizontalPosition: 'right',
      });
    })
  }
}
