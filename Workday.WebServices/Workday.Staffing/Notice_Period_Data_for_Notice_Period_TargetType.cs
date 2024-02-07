using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Notice_Period_Data_for_Notice_Period_TargetType : INotifyPropertyChanged
	{
		private Notice_Period_TargetObjectType notice_Period_Target_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Notice_Period_DataType[] employer_Notice_Period_DataField;

		private Notice_Period_DataType[] employee_Notice_Period_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Notice_Period_TargetObjectType Notice_Period_Target_Reference
		{
			get
			{
				return this.notice_Period_Target_ReferenceField;
			}
			set
			{
				this.notice_Period_Target_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Target_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Notice_Period_Data", typeof(Notice_Period_DataType), IsNullable = false)]
		public Notice_Period_DataType[] Employer_Notice_Period_Data
		{
			get
			{
				return this.employer_Notice_Period_DataField;
			}
			set
			{
				this.employer_Notice_Period_DataField = value;
				this.RaisePropertyChanged("Employer_Notice_Period_Data");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Notice_Period_Data", typeof(Notice_Period_DataType), IsNullable = false)]
		public Notice_Period_DataType[] Employee_Notice_Period_Data
		{
			get
			{
				return this.employee_Notice_Period_DataField;
			}
			set
			{
				this.employee_Notice_Period_DataField = value;
				this.RaisePropertyChanged("Employee_Notice_Period_Data");
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
