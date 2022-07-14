import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MojeTransportyComponent } from './moje-transporty.component';

describe('MojeTransportyComponent', () => {
  let component: MojeTransportyComponent;
  let fixture: ComponentFixture<MojeTransportyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MojeTransportyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MojeTransportyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
