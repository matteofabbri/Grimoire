using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiting_Cycle_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private Has_Academic_Curricular_Division_DataType[] academic_Unit_Subedit_DataField;

		private Academic_Date_RangeObjectType academic_Date_Range_ReferenceField;

		private string descriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement("Academic_Unit_Subedit_Data", Order = 2)]
		public Has_Academic_Curricular_Division_DataType[] Academic_Unit_Subedit_Data
		{
			get
			{
				return this.academic_Unit_Subedit_DataField;
			}
			set
			{
				this.academic_Unit_Subedit_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Subedit_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_Date_RangeObjectType Academic_Date_Range_Reference
		{
			get
			{
				return this.academic_Date_Range_ReferenceField;
			}
			set
			{
				this.academic_Date_Range_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Date_Range_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
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
