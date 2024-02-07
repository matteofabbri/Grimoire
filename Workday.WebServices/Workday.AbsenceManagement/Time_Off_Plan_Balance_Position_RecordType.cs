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
	public class Time_Off_Plan_Balance_Position_RecordType : INotifyPropertyChanged
	{
		private PositionObjectType position_ReferenceField;

		private decimal time_Off_Plan_BalanceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PositionObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Time_Off_Plan_Balance
		{
			get
			{
				return this.time_Off_Plan_BalanceField;
			}
			set
			{
				this.time_Off_Plan_BalanceField = value;
				this.RaisePropertyChanged("Time_Off_Plan_Balance");
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
