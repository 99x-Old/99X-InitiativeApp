import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { User } from '../_models/user';
import { AlertifyService } from '../_services/alertify.service';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-members',
  templateUrl: './members.component.html',
  styleUrls: ['./members.component.css']
})
export class MembersComponent implements OnInit {
	users: User[];
	userForms: FormArray = this.fb.array([]);

	constructor(private userService: UserService, private alertify: AlertifyService, private fb: FormBuilder) { }

	ngOnInit() {
		this.loadUsers();
		this.addUserForm();
	}

	addUserForm() {
		this.userForms.push(this.fb.group({
			username: [''],
			created: [''],
			isActive: ['']
		}))
	}

	loadUsers() {
		this.userService.getUsers().subscribe((users: User[]) => {
			this.users = users;
		}, error => {
			this.alertify.error(error);
		});
	}
}
