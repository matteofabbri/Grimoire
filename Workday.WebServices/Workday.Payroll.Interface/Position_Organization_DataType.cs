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
	public class Position_Organization_DataType : INotifyPropertyChanged
	{
		private Worker_Organization_Membership_DataType[] position_Organization_DataField;

		private Pay_Group_Assignment_Correct_or_Rescinded_Organization_DataType[] pay_Group_Assignment_Correct_or_Rescind_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Position_Organization_Data", Order = 0)]
		public Worker_Organization_Membership_DataType[] Position_Organization_Data
		{
			get
			{
				return this.position_Organization_DataField;
			}
			set
			{
				this.position_Organization_DataField = value;
				this.RaisePropertyChanged("Position_Organization_Data");
			}
		}

		[XmlElement("Pay_Group_Assignment_Correct_or_Rescind_Data", Order = 1)]
		public Pay_Group_Assignment_Correct_or_Rescinded_Organization_DataType[] Pay_Group_Assignment_Correct_or_Rescind_Data
		{
			get
			{
				return this.pay_Group_Assignment_Correct_or_Rescind_DataField;
			}
			set
			{
				this.pay_Group_Assignment_Correct_or_Rescind_DataField = value;
				this.RaisePropertyChanged("Pay_Group_Assignment_Correct_or_Rescind_Data");
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
