import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { Meeting } from '../_models/meeting';
import { AlertifyService } from '../_services/alertify.service';
import { MeetingService } from '../_services/meeting.service';

@Component({
  selector: 'app-meetings',
  templateUrl: './meetings.component.html',
  styleUrls: ['./meetings.component.css']
})
export class MeetingsComponent implements OnInit {

	meetings: Meeting[];
	meetingForms: FormArray = this.fb.array([]);

	constructor(private meetingService: MeetingService, private alertify: AlertifyService, private fb: FormBuilder) { }

	ngOnInit() {
		this.loadMeetings();
		this.addMeetingForm();
	}

	addMeetingForm() {
		this.meetingForms.push(this.fb.group({
			meetingName: [''],
			scheduledTime: [''],
			initiativeId: []
		}))
	}

	loadMeetings() {
		this.meetingService.getMeetings().subscribe((meetings: Meeting[]) => {
			this.meetings = meetings;
		}, error => {
			this.alertify.error(error);
		});
	}

}
