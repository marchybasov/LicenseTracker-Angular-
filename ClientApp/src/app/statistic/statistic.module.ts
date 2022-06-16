import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { StatisticTableComponent } from './statisticTable.component';
import { StatisticSelectionComponent } from './statisticSelection.component';
import { SpaModule } from '../spa/spa.module';

@NgModule({
  declarations: [StatisticSelectionComponent, StatisticTableComponent],
  imports: [BrowserModule, SpaModule],
  exports: [StatisticSelectionComponent],
})
export class StatisticModule {}
