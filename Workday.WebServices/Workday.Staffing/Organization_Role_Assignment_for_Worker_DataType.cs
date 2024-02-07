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
	public class Organization_Role_Assignment_for_Worker_DataType : INotifyPropertyChanged
	{
		private Role_AssignerObjectType role_Assigner_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string assignment_FromField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Role_AssignerObjectType Role_Assigner_Reference
		{
			get
			{
				return this.role_Assigner_ReferenceField;
			}
			set
			{
				this.role_Assigner_ReferenceField = value;
				this.RaisePropertyChanged("Role_Assigner_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Assignment_From
		{
			get
			{
				return this.assignment_FromField;
			}
			set
			{
				this.assignment_FromField = value;
				this.RaisePropertyChanged("Assignment_From");
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
