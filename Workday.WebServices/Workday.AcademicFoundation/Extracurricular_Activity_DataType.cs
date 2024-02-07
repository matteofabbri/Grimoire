using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Extracurricular_Activity_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string extracurricular_Activity_NameField;

		private Has_Academic_Unit_with_Shareable_Subordinates_DataType[] academic_Unit_Shareable_DataField;

		private Extracurricular_Activity_CategoryObjectType[] extracurricular_Activity_Category_ReferenceField;

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
		public string Extracurricular_Activity_Name
		{
			get
			{
				return this.extracurricular_Activity_NameField;
			}
			set
			{
				this.extracurricular_Activity_NameField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Name");
			}
		}

		[XmlElement("Academic_Unit_Shareable_Data", Order = 2)]
		public Has_Academic_Unit_with_Shareable_Subordinates_DataType[] Academic_Unit_Shareable_Data
		{
			get
			{
				return this.academic_Unit_Shareable_DataField;
			}
			set
			{
				this.academic_Unit_Shareable_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Shareable_Data");
			}
		}

		[XmlElement("Extracurricular_Activity_Category_Reference", Order = 3)]
		public Extracurricular_Activity_CategoryObjectType[] Extracurricular_Activity_Category_Reference
		{
			get
			{
				return this.extracurricular_Activity_Category_ReferenceField;
			}
			set
			{
				this.extracurricular_Activity_Category_ReferenceField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Category_Reference");
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
