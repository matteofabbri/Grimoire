using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Repository_Document_MetadataType : INotifyPropertyChanged
	{
		private string file_NameField;

		private string created_byField;

		private DateTime date_and_Time_CreatedField;

		private bool date_and_Time_CreatedFieldSpecified;

		private Report_Output_TagObjectType[] report_Tag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string File_Name
		{
			get
			{
				return this.file_NameField;
			}
			set
			{
				this.file_NameField = value;
				this.RaisePropertyChanged("File_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Created_by
		{
			get
			{
				return this.created_byField;
			}
			set
			{
				this.created_byField = value;
				this.RaisePropertyChanged("Created_by");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Date_and_Time_Created
		{
			get
			{
				return this.date_and_Time_CreatedField;
			}
			set
			{
				this.date_and_Time_CreatedField = value;
				this.RaisePropertyChanged("Date_and_Time_Created");
			}
		}

		[XmlIgnore]
		public bool Date_and_Time_CreatedSpecified
		{
			get
			{
				return this.date_and_Time_CreatedFieldSpecified;
			}
			set
			{
				this.date_and_Time_CreatedFieldSpecified = value;
				this.RaisePropertyChanged("Date_and_Time_CreatedSpecified");
			}
		}

		[XmlElement("Report_Tag_Reference", Order = 3)]
		public Report_Output_TagObjectType[] Report_Tag_Reference
		{
			get
			{
				return this.report_Tag_ReferenceField;
			}
			set
			{
				this.report_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Report_Tag_Reference");
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
