import { Time } from '@angular/common';

export interface Meeting {
	meetingId: number;
	meetingName: string;
	scheduledTime: Date;
	initiativeId: number;
}