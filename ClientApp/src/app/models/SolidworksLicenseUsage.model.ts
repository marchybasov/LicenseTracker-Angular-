import { Users } from './User.model';
import { UsageAction } from './UsageAction.model';
import { Feature } from './Feature.model';
import { UserPCs } from './UserPC.model';

export class SolidworksLicenseUsage {
  constructor(
    public id?: number,
    public createdAt?: Date,
    public featureFeature?: Feature,
    public usageActionUsageAction?: UsageAction,
    public userUser?: Users,
    public userPcUserPc?: UserPCs,
    public currentlyOccupiedLicense?: number
  ) {}
}
