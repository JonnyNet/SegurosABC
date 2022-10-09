import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';

const components = [
  HeaderComponent,
  LoadingSpinnerComponent,
];

const modules = [
  CommonModule,
  HttpClientModule,
  FormsModule,
  ReactiveFormsModule,
  MatIconModule,
  MatFormFieldModule,
  MatInputModule,
  MatTableModule,
  MatButtonModule,
];

@NgModule({
  declarations: [...components],
  imports: [...modules],
  exports: [
    ...modules,
    ...components,
  ]
})
export class SharedModule { }
