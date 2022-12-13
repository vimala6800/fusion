import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListReqComponent } from './list-req.component';

describe('ListReqComponent', () => {
  let component: ListReqComponent;
  let fixture: ComponentFixture<ListReqComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListReqComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListReqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
