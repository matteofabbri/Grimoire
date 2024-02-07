using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Student_Recruiting_Campaign_RequestType : INotifyPropertyChanged
	{
		private Student_Recruiting_CampaignObjectType student_Recruiting_Campaign_ReferenceField;

		private Student_Business_Process_ParametersType student_Business_Process_ParametersField;

		private Student_Recruiting_Campaign_DataType student_Recruiting_Campaign_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Recruiting_CampaignObjectType Student_Recruiting_Campaign_Reference
		{
			get
			{
				return this.student_Recruiting_Campaign_ReferenceField;
			}
			set
			{
				this.student_Recruiting_Campaign_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiting_Campaign_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Business_Process_ParametersType Student_Business_Process_Parameters
		{
			get
			{
				return this.student_Business_Process_ParametersField;
			}
			set
			{
				this.student_Business_Process_ParametersField = value;
				this.RaisePropertyChanged("Student_Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Recruiting_Campaign_DataType Student_Recruiting_Campaign_Data
		{
			get
			{
				return this.student_Recruiting_Campaign_DataField;
			}
			set
			{
				this.student_Recruiting_Campaign_DataField = value;
				this.RaisePropertyChanged("Student_Recruiting_Campaign_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
