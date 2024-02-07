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
	public class Override_BalanceType : INotifyPropertyChanged
	{
		private Time_Off_Plan_BalanceObjectType override_Balance_ReferenceField;

		private Override_Balance_DataType override_Balance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Time_Off_Plan_BalanceObjectType Override_Balance_Reference
		{
			get
			{
				return this.override_Balance_ReferenceField;
			}
			set
			{
				this.override_Balance_ReferenceField = value;
				this.RaisePropertyChanged("Override_Balance_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Override_Balance_DataType Override_Balance_Data
		{
			get
			{
				return this.override_Balance_DataField;
			}
			set
			{
				this.override_Balance_DataField = value;
				this.RaisePropertyChanged("Override_Balance_Data");
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
