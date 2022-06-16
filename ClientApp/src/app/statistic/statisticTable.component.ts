import { Component } from '@angular/core';
import { Repository } from '../models/repository';
import { Statistic } from '../models/UsageStatistic.model';
import { Router } from '@angular/router';

@Component({
  selector: 'statistic-table',
  templateUrl: 'statisticTable.component.html',
})
export class StatisticTableComponent {
  Math: any;
  constructor(private repo: Repository, private router: Router) {
    this.Math = Math;
  }

  get statistic(): Statistic {
    return this.repo.statistic;
  }
}
