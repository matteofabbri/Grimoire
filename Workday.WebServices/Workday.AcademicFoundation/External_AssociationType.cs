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
	public class External_AssociationType : INotifyPropertyChanged
	{
		private External_AssociationObjectType external_Association_ReferenceField;

		private External_Association_DataType external_Association_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_AssociationObjectType External_Association_Reference
		{
			get
			{
				return this.external_Association_ReferenceField;
			}
			set
			{
				this.external_Association_ReferenceField = value;
				this.RaisePropertyChanged("External_Association_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public External_Association_DataType External_Association_Data
		{
			get
			{
				return this.external_Association_DataField;
			}
			set
			{
				this.external_Association_DataField = value;
				this.RaisePropertyChanged("External_Association_Data");
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
