import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { PcsListComponent } from './pcsList.component';
import { PcsSelectionComponent } from './pcsSelection.component';
import { SpaModule } from '../spa/spa.module';
import { importType } from '@angular/compiler/src/output/output_ast';

@NgModule({
  declarations: [PcsSelectionComponent, PcsListComponent],
  imports: [BrowserModule, SpaModule],
  exports: [PcsSelectionComponent],
})
export class PcsModule {}
