using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Leaves_Returning_from_DataType : INotifyPropertyChanged
	{
		private Leave_Request_EventObjectType request_Leave_of_Absence_ReferenceField;

		private bool correctionField;

		private bool correctionFieldSpecified;

		private DateTime actual_Last_Day_of_LeaveField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Leave_Request_EventObjectType Request_Leave_of_Absence_Reference
		{
			get
			{
				return this.request_Leave_of_Absence_ReferenceField;
			}
			set
			{
				this.request_Leave_of_Absence_ReferenceField = value;
				this.RaisePropertyChanged("Request_Leave_of_Absence_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Correction
		{
			get
			{
				return this.correctionField;
			}
			set
			{
				this.correctionField = value;
				this.RaisePropertyChanged("Correction");
			}
		}

		[XmlIgnore]
		public bool CorrectionSpecified
		{
			get
			{
				return this.correctionFieldSpecified;
			}
			set
			{
				this.correctionFieldSpecified = value;
				this.RaisePropertyChanged("CorrectionSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Actual_Last_Day_of_Leave
		{
			get
			{
				return this.actual_Last_Day_of_LeaveField;
			}
			set
			{
				this.actual_Last_Day_of_LeaveField = value;
				this.RaisePropertyChanged("Actual_Last_Day_of_Leave");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
