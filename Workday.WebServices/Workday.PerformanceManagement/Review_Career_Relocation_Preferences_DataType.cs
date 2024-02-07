using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_Career_Relocation_Preferences_DataType : INotifyPropertyChanged
	{
		private Common_Boolean_EnumerationObjectType short_Term_Relocation_ReferenceField;

		private Relocation_AreaObjectType[] short_Term_Relocation_Area_ReferenceField;

		private Common_Boolean_EnumerationObjectType long_Term_Relocation_ReferenceField;

		private Relocation_AreaObjectType[] long_Term_Relocation_Area_ReferenceField;

		private string relocation_Additional_InformationField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Common_Boolean_EnumerationObjectType Short_Term_Relocation_Reference
		{
			get
			{
				return this.short_Term_Relocation_ReferenceField;
			}
			set
			{
				this.short_Term_Relocation_ReferenceField = value;
				this.RaisePropertyChanged("Short_Term_Relocation_Reference");
			}
		}

		[XmlElement("Short_Term_Relocation_Area_Reference", Order = 1)]
		public Relocation_AreaObjectType[] Short_Term_Relocation_Area_Reference
		{
			get
			{
				return this.short_Term_Relocation_Area_ReferenceField;
			}
			set
			{
				this.short_Term_Relocation_Area_ReferenceField = value;
				this.RaisePropertyChanged("Short_Term_Relocation_Area_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Common_Boolean_EnumerationObjectType Long_Term_Relocation_Reference
		{
			get
			{
				return this.long_Term_Relocation_ReferenceField;
			}
			set
			{
				this.long_Term_Relocation_ReferenceField = value;
				this.RaisePropertyChanged("Long_Term_Relocation_Reference");
			}
		}

		[XmlElement("Long_Term_Relocation_Area_Reference", Order = 3)]
		public Relocation_AreaObjectType[] Long_Term_Relocation_Area_Reference
		{
			get
			{
				return this.long_Term_Relocation_Area_ReferenceField;
			}
			set
			{
				this.long_Term_Relocation_Area_ReferenceField = value;
				this.RaisePropertyChanged("Long_Term_Relocation_Area_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Relocation_Additional_Information
		{
			get
			{
				return this.relocation_Additional_InformationField;
			}
			set
			{
				this.relocation_Additional_InformationField = value;
				this.RaisePropertyChanged("Relocation_Additional_Information");
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
