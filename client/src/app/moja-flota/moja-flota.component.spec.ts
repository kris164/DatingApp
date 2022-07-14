import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MojaFlotaComponent } from './moja-flota.component';

describe('MojaFlotaComponent', () => {
  let component: MojaFlotaComponent;
  let fixture: ComponentFixture<MojaFlotaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MojaFlotaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MojaFlotaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
