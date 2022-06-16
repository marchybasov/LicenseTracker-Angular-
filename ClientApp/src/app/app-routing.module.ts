import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserSelectionComponent } from './spa/userSelection.component';
import { StatisticSelectionComponent } from './statistic/statisticSelection.component';

const routes: Routes = [
  { path: 'spa/:category/:page', component: UserSelectionComponent },
  { path: 'spa/:categoryOrPage', component: UserSelectionComponent },
  { path: 'spa', component: UserSelectionComponent },
  { path: 'statistic/:category', component: StatisticSelectionComponent },
  { path: 'statistic', component: StatisticSelectionComponent },
  { path: '', redirectTo: '/statistic', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
