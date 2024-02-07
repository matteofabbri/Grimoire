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
	public class Recruiting_RegionType : INotifyPropertyChanged
	{
		private RegionObjectType recruiting_Region_ReferenceField;

		private Recruiting_Region_DataType recruiting_Region_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RegionObjectType Recruiting_Region_Reference
		{
			get
			{
				return this.recruiting_Region_ReferenceField;
			}
			set
			{
				this.recruiting_Region_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Region_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Recruiting_Region_DataType Recruiting_Region_Data
		{
			get
			{
				return this.recruiting_Region_DataField;
			}
			set
			{
				this.recruiting_Region_DataField = value;
				this.RaisePropertyChanged("Recruiting_Region_Data");
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
