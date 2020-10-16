import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { InitiativesComponent } from './initiatives/initiatives.component';
import { MembersComponent } from './members/members.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
	{ path: '', component: HomeComponent },
	{
		path: '',
		runGuardsAndResolvers: 'always',
		canActivate: [AuthGuard],
		children: [
			{ path: 'members', component: MembersComponent },
			{ path: 'initiatives', component: InitiativesComponent },
		]
	},
	{ path: '**', redirectTo: '', pathMatch: 'full' }
];
