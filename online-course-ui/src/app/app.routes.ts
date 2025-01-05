import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { AboutUsComponent } from './components/core/about-us/about-us.component';
import { PlansAndPricingComponent } from './components/plans-and-pricing/plans-and-pricing.component';
import { ContactUsComponent } from './components/core/contact-us/contact-us.component';
import { CourseByCategoryComponent } from './components/course/course-by-category/course-by-category.component';
import { BrowseCourseComponent } from './components/course/browse-course/browse-course.component';
import { DataBindingComponent } from './components/basic/data-binding/data-binding.component';
import { DirectivesDemoComponent } from './components/basic/directives-demo/directives-demo.component';

export const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full'},
    { path: 'home', component: HomeComponent},
    { path: 'about-us', component: AboutUsComponent},
    { path: 'contact-us', component: ContactUsComponent},
    { path: 'plans-and-price', component: PlansAndPricingComponent},
    { path: 'examples/data-binding', component: DataBindingComponent },
    { path: 'examples/directives', component: DirectivesDemoComponent },
    { path: 'course/category/:categoryId', component: CourseByCategoryComponent },
    // { path: 'course/browse', component: BrowseCourseComponent},
];
