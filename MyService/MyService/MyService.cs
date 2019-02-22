﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.InteropServices;

namespace MyService
{
  public partial class MyService : ServiceBase
  {
    private System.Diagnostics.EventLog eventLog1;
    private int eventId = 1;
    private System.Timers.Timer timer;
    public MyService()
    {
      InitializeComponent();

      eventLog1 = new System.Diagnostics.EventLog();
      if (!System.Diagnostics.EventLog.SourceExists("MySource"))
      {
        System.Diagnostics.EventLog.CreateEventSource("MySource", "MyLog");
      }

      eventLog1.Source = "MySource";
      eventLog1.Log = "MyLog";
    }



    protected override void OnStart(string[] args)
    {
      // Update the service state to Start Pending.
      ServiceStatus serviceStatus = new ServiceStatus();
      serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING;
      serviceStatus.dwWaitHint = 100000;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);

      eventLog1.WriteEntry("Service MyService is starting.");

      // Set up a timer that triggers every minute.
      timer = new System.Timers.Timer();
      timer.Interval = 60000; // 60 seconds
      timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
      timer.Start();

      // Update the service state to Running.
      serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);
    }

    private void OnTimer(object sender, ElapsedEventArgs e)
    {
      eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
    }

    protected override void OnStop()
    {
      // Update the service state to Start Pending.
      ServiceStatus serviceStatus = new ServiceStatus();
      serviceStatus.dwCurrentState = ServiceState.SERVICE_STOP_PENDING;
      serviceStatus.dwWaitHint = 100000;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);

      eventLog1.WriteEntry("Service MyService is stopping.");
      timer.Stop();

      // Update the service state to Running.
      serviceStatus.dwCurrentState = ServiceState.SERVICE_STOPPED;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);
    }

    [DllImport("advapi32.dll", SetLastError = true)]
    private static extern bool SetServiceStatus(System.IntPtr handle, ref ServiceStatus serviceStatus);
  }

  public enum ServiceState
  {
    SERVICE_STOPPED = 0x00000001,
    SERVICE_START_PENDING = 0x00000002,
    SERVICE_STOP_PENDING = 0x00000003,
    SERVICE_RUNNING = 0x00000004,
    SERVICE_CONTINUE_PENDING = 0x00000005,
    SERVICE_PAUSE_PENDING = 0x00000006,
    SERVICE_PAUSED = 0x00000007,
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct ServiceStatus
  {
    public int dwServiceType;
    public ServiceState dwCurrentState;
    public int dwControlsAccepted;
    public int dwWin32ExitCode;
    public int dwServiceSpecificExitCode;
    public int dwCheckPoint;
    public int dwWaitHint;
  };
}
