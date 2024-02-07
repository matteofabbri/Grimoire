using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Review_Type_RequestType : INotifyPropertyChanged
	{
		private Review_TypeObjectType review_Type_ReferenceField;

		private Review_Type_DataType review_Type_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Review_TypeObjectType Review_Type_Reference
		{
			get
			{
				return this.review_Type_ReferenceField;
			}
			set
			{
				this.review_Type_ReferenceField = value;
				this.RaisePropertyChanged("Review_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Review_Type_DataType Review_Type_Data
		{
			get
			{
				return this.review_Type_DataField;
			}
			set
			{
				this.review_Type_DataField = value;
				this.RaisePropertyChanged("Review_Type_Data");
			}
		}

		[XmlElement(Order = 2)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
