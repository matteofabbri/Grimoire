using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_External_Pay_Group_DataType : INotifyPropertyChanged
	{
		private Pay_GroupObjectType external_Pay_Group_ReferenceField;

		private Last_Extract_Created_DataType last_Extract_Created_DataField;

		private Period_Status_DataType period_Status_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_GroupObjectType External_Pay_Group_Reference
		{
			get
			{
				return this.external_Pay_Group_ReferenceField;
			}
			set
			{
				this.external_Pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("External_Pay_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Last_Extract_Created_DataType Last_Extract_Created_Data
		{
			get
			{
				return this.last_Extract_Created_DataField;
			}
			set
			{
				this.last_Extract_Created_DataField = value;
				this.RaisePropertyChanged("Last_Extract_Created_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Period_Status_DataType Period_Status_Data
		{
			get
			{
				return this.period_Status_DataField;
			}
			set
			{
				this.period_Status_DataField = value;
				this.RaisePropertyChanged("Period_Status_Data");
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
