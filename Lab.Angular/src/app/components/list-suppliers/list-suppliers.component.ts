import { AfterViewInit,Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Supplier } from 'src/app/interfaces/supplier';

const listSuppliers: Supplier[] = [
  {supplierId: 204, companyName: 'Sociedad', contactName: '(548) 4545461'},
  {supplierId: 205, companyName: 'Sociedad', contactName: '(548) 4545461'},
  {supplierId: 206, companyName: 'Sociedad', contactName: '(548) 4545461'},
  {supplierId: 207, companyName: 'Sociedad', contactName: '(548) 4545461'},

];

@Component({
  selector: 'app-list-suppliers',
  templateUrl: './list-suppliers.component.html',
  styleUrls: ['./list-suppliers.component.css']
})
export class ListSuppliersComponent implements OnInit,AfterViewInit {
  displayedColumns: string[] = ['supplierId', 'companyName', 'contactName', 'acciones'];
  dataSource = new MatTableDataSource<Supplier>(listSuppliers);
  loading: boolean = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _snackBar: MatSnackBar) { }

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
  
  deleteProduct() {
    this.loading = true;

    setTimeout(() => {
      this.loading = false;
      this._snackBar.open('Producto eliminado correctamente', '', {
        duration: 4000,
        horizontalPosition: 'right',
      });
    }, 3000);
  }

}
